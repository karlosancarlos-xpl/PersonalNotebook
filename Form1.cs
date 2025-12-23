namespace Notebook
{
    public partial class frmNotebook : Form
    {
        public NotebookRepository repo;

        public frmNotebook()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

            repo = new NotebookRepository()
            {
                TitleTextBox = tbLastPadTitle,
                ContentTextBox = tbLastPad,
                fileName = "notebook.bin"
            };

            btnExpandCurrentPad.Click += BtnExpandCurrentPad_Click;
            btnNewPage.Click += BtnNewPage_Click;
            tlpForm.SizeChanged += tlpForm_SizeChanged;
            repo.NotebookChanged += Repo_NotebookChanged;

            Load += FrmNotebook_Load;
        }

        private void FrmNotebook_Load(object? sender, EventArgs e)
        {
            repo.LoadNotebook();

            foreach (var page in repo.Notebook.Pages)
            {
                GenerateTab(page.Title, page);
            }
        }

        private void tlpForm_SizeChanged(object? sender, EventArgs e)
        {
            tbCurrentPad.Height = tlpForm.ClientSize.Height - tlpCurrentPadTitleContainer.Height - 20;
            tbCurrentPad.Text = Width + " x " + Height;
        }

        private void BtnExpandCurrentPad_Click(object? sender, EventArgs e)
        {
            ToggleRightSideVisibility(!tbLastPadTitle.Visible);
        }

        private void Repo_NotebookChanged(object? sender, EventArgs e)
        {
            GenerateTab(tbCurrentPadTitle.Text.Trim(), repo.Notebook.Pages[^1]);
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            var notebookPage = (sender as Button)?.Tag as NotebookPage;

            tbLastPadTitle.Text = notebookPage.Title;
            tbLastPad.Text = notebookPage.Content;
        }

        private void BtnNewPage_Click(object? sender, EventArgs e)
        {
            if (tbCurrentPad.Text.Trim().Length == 0)
                return;

            if (tbCurrentPadTitle.Text.Trim().Length == 0)
                tbCurrentPadTitle.Text = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            repo.PutCurrentPageToLastPage(tbCurrentPadTitle.Text, tbCurrentPad.Text);
            repo.SaveNotebook();

            tbCurrentPadTitle.Text = "";
            tbCurrentPad.Text = "";
        }

        private void GenerateTab(string title, NotebookPage page)
        {
            Button button = new Button();
            button.AutoSize = true;
            button.Text = title == string.Empty ? "Unnamed" : title;
            button.Tag = page;
            button.Click += Button_Click;

            flpPreviousPads.Controls.Add(button);
            flpPreviousPads.Controls.SetChildIndex(button, 0);
        }

        private void ToggleRightSideVisibility(bool visible)
        {
            tbLastPadTitle?.Visible = visible;
            tbLastPad.Visible = visible;
            flpPreviousPads?.Visible = visible;

            tlpForm.SetColumnSpan(tlpCurrentPadTitleContainer, visible ? 1 : 2);
            tlpCurrentPadTitleContainer.SetColumnSpan(btnExpandCurrentPad, visible ? 1 : 2);
            tlpForm.SetColumnSpan(tbCurrentPad, visible ? 1 : 2);

            btnNewPage.Visible = visible;

            btnExpandCurrentPad.Text = visible ? ">>" : "<<";
        }
    }
}
