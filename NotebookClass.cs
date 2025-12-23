#pragma warning disable CS8622
#pragma warning disable CS8618
#pragma warning disable IDE1006

namespace Notebook
{
    public class NotebookRepository
    {
        public string fileName { get; set; }
        public NotebookClass Notebook { get; set; }
        public Controls.CTextBox TitleTextBox { get; set; }
        public Controls.CTextBox ContentTextBox { get; set; }

        public event EventHandler NotebookChanged;

        public void PutCurrentPageToLastPage(string title, string content)
        {
            var notebookPage = new NotebookPage(title, content);

            TitleTextBox.Text = title;
            ContentTextBox.Text = content;

            Notebook.AddPage(notebookPage);
        }

        public void LoadNotebook()
        {
            Notebook = BinaryNotebookStorage.Load(fileName);
            Notebook.PageAdded += Notebook_PageAdded;

            if (Notebook.Pages.Count == 0)
                return;

            var latestPage = Notebook.Pages[^1];

            TitleTextBox.Text = latestPage.Title;
            ContentTextBox.Text = latestPage.Content;
        }

        public void SaveNotebook()
        {
            BinaryNotebookStorage.Save(Notebook, fileName);
        }

        private void Notebook_PageAdded(object? sender, EventArgs e)
        {
            NotebookChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    public class NotebookClass
    {
        public List<NotebookPage> Pages { get; private set; } = [];
        public event EventHandler PageAdded;

        public bool AddPage(NotebookPage page)
        {
            if (Pages.Contains(page) || Pages.Exists(p => p.Equals(page)))
                return false;

            Pages.Add(page);

            PageAdded?.Invoke(this, EventArgs.Empty);
            return true;
        }
    }
    
    public class NotebookPage
    {
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";

        public NotebookPage(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public override bool Equals(object? obj)
        {
            var b = obj as NotebookPage;

            if (ReferenceEquals(this, b)) return true;

            if (b == null) return false;

            if (Title == b.Title && Content == b.Content) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public static class BinaryNotebookStorage
    {
        public static void Save(NotebookClass notebook, string fileName)
        {
            using var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            using var writer = new BinaryWriter(fs);

            writer.Write(notebook.Pages.Count);

            foreach (var page in notebook.Pages)
            {
                writer.Write(page.Title);
                writer.Write(page.Content);
            }
        }

        public static NotebookClass Load(string fileName)
        {
            var notebook = new NotebookClass();

            if (!File.Exists(fileName))
                return notebook;

            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(fs))
            {
                int pageCount = reader.ReadInt32();

                for (int i = 0; i < pageCount; i++)
                {
                    string title = reader.ReadString();
                    string content = reader.ReadString();
                    var page = new NotebookPage(title, content);
                    notebook.AddPage(page);
                }
            }

            return notebook;
        }
    }
}
