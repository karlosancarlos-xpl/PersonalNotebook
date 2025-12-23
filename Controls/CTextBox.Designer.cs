namespace Notebook.Controls
{
    partial class CTextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbContent = new TextBox();
            SuspendLayout();
            // 
            // tbContent
            // 
            tbContent.BackColor = SystemColors.Control;
            tbContent.BorderStyle = BorderStyle.None;
            tbContent.Dock = DockStyle.Fill;
            tbContent.Location = new Point(0, 0);
            tbContent.Name = "tbContent";
            tbContent.ScrollBars = ScrollBars.Both;
            tbContent.Size = new Size(376, 16);
            tbContent.TabIndex = 0;
            // 
            // CTextBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(tbContent);
            Margin = new Padding(0);
            Name = "CTextBox";
            Size = new Size(376, 20);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbContent;
    }
}
