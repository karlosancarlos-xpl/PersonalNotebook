namespace Notebook
{
    partial class frmNotebook
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotebook));
            tlpForm = new TableLayoutPanel();
            tbCurrentPad = new Notebook.Controls.CTextBox();
            tbLastPadTitle = new Notebook.Controls.CTextBox();
            tlpCurrentPadTitleContainer = new TableLayoutPanel();
            btnExpandCurrentPad = new Button();
            btnNewPage = new Button();
            tbCurrentPadTitle = new Notebook.Controls.CTextBox();
            splitContainer1 = new SplitContainer();
            tbLastPad = new Notebook.Controls.CTextBox();
            flpPreviousPads = new FlowLayoutPanel();
            tlpForm.SuspendLayout();
            tlpCurrentPadTitleContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpForm
            // 
            tlpForm.ColumnCount = 2;
            tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpForm.Controls.Add(tbCurrentPad, 0, 1);
            tlpForm.Controls.Add(tbLastPadTitle, 1, 0);
            tlpForm.Controls.Add(tlpCurrentPadTitleContainer, 0, 0);
            tlpForm.Controls.Add(splitContainer1, 1, 1);
            tlpForm.Dock = DockStyle.Fill;
            tlpForm.Location = new Point(0, 0);
            tlpForm.Name = "tlpForm";
            tlpForm.RowCount = 2;
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpForm.RowStyles.Add(new RowStyle());
            tlpForm.Size = new Size(800, 538);
            tlpForm.TabIndex = 0;
            // 
            // tbCurrentPad
            // 
            tbCurrentPad.BackColor = SystemColors.Control;
            tbCurrentPad.BorderColor = Color.CornflowerBlue;
            tbCurrentPad.BorderThickness = 1.5F;
            tbCurrentPad.Dock = DockStyle.Fill;
            tbCurrentPad.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCurrentPad.HighlightBorderColor = Color.RoyalBlue;
            tbCurrentPad.Location = new Point(0, 80);
            tbCurrentPad.Margin = new Padding(0);
            tbCurrentPad.MultiLine = true;
            tbCurrentPad.Name = "tbCurrentPad";
            tbCurrentPad.Padding = new Padding(22, 20, 22, 20);
            tbCurrentPad.PlaceholderText = "Enter your notes here...";
            tbCurrentPad.ReadOnly = false;
            tbCurrentPad.Size = new Size(400, 458);
            tbCurrentPad.TabIndex = 9;
            // 
            // tbLastPadTitle
            // 
            tbLastPadTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbLastPadTitle.BackColor = SystemColors.Control;
            tbLastPadTitle.BorderColor = Color.LightSteelBlue;
            tbLastPadTitle.BorderThickness = 1.5F;
            tbLastPadTitle.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLastPadTitle.ForeColor = Color.FromArgb(64, 64, 64);
            tbLastPadTitle.HighlightBorderColor = Color.CornflowerBlue;
            tbLastPadTitle.Location = new Point(408, 18);
            tbLastPadTitle.Margin = new Padding(8, 3, 8, 3);
            tbLastPadTitle.MultiLine = false;
            tbLastPadTitle.Name = "tbLastPadTitle";
            tbLastPadTitle.Padding = new Padding(12);
            tbLastPadTitle.PlaceholderText = "No notes loaded yet";
            tbLastPadTitle.ReadOnly = true;
            tbLastPadTitle.Size = new Size(384, 43);
            tbLastPadTitle.TabIndex = 7;
            // 
            // tlpCurrentPadTitleContainer
            // 
            tlpCurrentPadTitleContainer.ColumnCount = 3;
            tlpCurrentPadTitleContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCurrentPadTitleContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpCurrentPadTitleContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpCurrentPadTitleContainer.Controls.Add(btnExpandCurrentPad, 1, 0);
            tlpCurrentPadTitleContainer.Controls.Add(btnNewPage, 2, 0);
            tlpCurrentPadTitleContainer.Controls.Add(tbCurrentPadTitle, 0, 0);
            tlpCurrentPadTitleContainer.Dock = DockStyle.Fill;
            tlpCurrentPadTitleContainer.Location = new Point(3, 3);
            tlpCurrentPadTitleContainer.Name = "tlpCurrentPadTitleContainer";
            tlpCurrentPadTitleContainer.RowCount = 1;
            tlpCurrentPadTitleContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCurrentPadTitleContainer.Size = new Size(394, 74);
            tlpCurrentPadTitleContainer.TabIndex = 4;
            // 
            // btnExpandCurrentPad
            // 
            btnExpandCurrentPad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnExpandCurrentPad.BackColor = Color.CornflowerBlue;
            btnExpandCurrentPad.FlatAppearance.BorderSize = 0;
            btnExpandCurrentPad.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnExpandCurrentPad.FlatStyle = FlatStyle.Flat;
            btnExpandCurrentPad.ForeColor = Color.White;
            btnExpandCurrentPad.Location = new Point(197, 19);
            btnExpandCurrentPad.Name = "btnExpandCurrentPad";
            btnExpandCurrentPad.Size = new Size(94, 36);
            btnExpandCurrentPad.TabIndex = 5;
            btnExpandCurrentPad.Text = ">>";
            btnExpandCurrentPad.UseVisualStyleBackColor = false;
            // 
            // btnNewPage
            // 
            btnNewPage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnNewPage.BackColor = Color.CornflowerBlue;
            btnNewPage.FlatAppearance.BorderSize = 0;
            btnNewPage.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnNewPage.FlatStyle = FlatStyle.Flat;
            btnNewPage.ForeColor = Color.White;
            btnNewPage.Location = new Point(297, 19);
            btnNewPage.Name = "btnNewPage";
            btnNewPage.Size = new Size(94, 36);
            btnNewPage.TabIndex = 4;
            btnNewPage.Text = "New Page";
            btnNewPage.UseVisualStyleBackColor = false;
            // 
            // tbCurrentPadTitle
            // 
            tbCurrentPadTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbCurrentPadTitle.BackColor = SystemColors.Control;
            tbCurrentPadTitle.BorderColor = Color.CornflowerBlue;
            tbCurrentPadTitle.BorderThickness = 1.5F;
            tbCurrentPadTitle.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCurrentPadTitle.HighlightBorderColor = Color.RoyalBlue;
            tbCurrentPadTitle.Location = new Point(0, 15);
            tbCurrentPadTitle.Margin = new Padding(0);
            tbCurrentPadTitle.MultiLine = false;
            tbCurrentPadTitle.Name = "tbCurrentPadTitle";
            tbCurrentPadTitle.Padding = new Padding(12);
            tbCurrentPadTitle.PlaceholderText = "Enter your title here...";
            tbCurrentPadTitle.ReadOnly = false;
            tbCurrentPadTitle.Size = new Size(194, 43);
            tbCurrentPadTitle.TabIndex = 6;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(403, 83);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tbLastPad);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flpPreviousPads);
            splitContainer1.Size = new Size(394, 452);
            splitContainer1.SplitterDistance = 226;
            splitContainer1.TabIndex = 5;
            // 
            // tbLastPad
            // 
            tbLastPad.BackColor = SystemColors.Control;
            tbLastPad.BorderColor = Color.LightSteelBlue;
            tbLastPad.BorderThickness = 1.5F;
            tbLastPad.Dock = DockStyle.Fill;
            tbLastPad.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLastPad.ForeColor = Color.FromArgb(64, 64, 64);
            tbLastPad.HighlightBorderColor = Color.CornflowerBlue;
            tbLastPad.Location = new Point(0, 0);
            tbLastPad.Margin = new Padding(0);
            tbLastPad.MultiLine = true;
            tbLastPad.Name = "tbLastPad";
            tbLastPad.Padding = new Padding(22, 16, 22, 16);
            tbLastPad.PlaceholderText = "";
            tbLastPad.ReadOnly = true;
            tbLastPad.Size = new Size(394, 226);
            tbLastPad.TabIndex = 8;
            // 
            // flpPreviousPads
            // 
            flpPreviousPads.AutoScroll = true;
            flpPreviousPads.AutoSize = true;
            flpPreviousPads.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpPreviousPads.Dock = DockStyle.Fill;
            flpPreviousPads.Location = new Point(0, 0);
            flpPreviousPads.Name = "flpPreviousPads";
            flpPreviousPads.Size = new Size(394, 222);
            flpPreviousPads.TabIndex = 0;
            // 
            // frmNotebook
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 538);
            Controls.Add(tlpForm);
            DoubleBuffered = true;
            Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(816, 577);
            Name = "frmNotebook";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Notebook - Kaloy SC";
            TopMost = true;
            tlpForm.ResumeLayout(false);
            tlpCurrentPadTitleContainer.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpForm;
        private TableLayoutPanel tlpCurrentPadTitleContainer;
        private Button btnNewPage;
        private SplitContainer splitContainer1;
        private Button btnExpandCurrentPad;
        private FlowLayoutPanel flpPreviousPads;
        private Controls.CTextBox tbCurrentPadTitle;
        private Controls.CTextBox tbLastPadTitle;
        private Controls.CTextBox tbLastPad;
        private Controls.CTextBox tbCurrentPad;
    }
}
