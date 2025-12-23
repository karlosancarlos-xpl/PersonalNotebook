using System.ComponentModel;

namespace Notebook.Controls
{
    public partial class CTextBox : UserControl
    {
        private float borderThickness = 4f;
        private Color borderColor = SystemColors.ActiveBorder;
        private Color highlightBorderColor = SystemColors.Highlight;
        private Color currentBorderColor = SystemColors.ActiveBorder;

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text { get => tbContent.Text; set => tbContent.Text = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float BorderThickness
        {
            get => borderThickness;
            set
            {
                borderThickness = value;
                Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = currentBorderColor = value;
                Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HighlightBorderColor
        {
            get => highlightBorderColor;
            set
            {
                highlightBorderColor = value;
                Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PlaceholderText
        {
            get => tbContent.PlaceholderText;
            set => tbContent.PlaceholderText = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool MultiLine
        {
            get => tbContent.Multiline;
            set => tbContent.Multiline = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ReadOnly
        {
            get => tbContent.ReadOnly;
            set => tbContent?.ReadOnly = value;
        }

        public CTextBox()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

            SizeChanged += CTextBox_SizeChanged;
            Enter += CTextBox_Enter;
            Leave += CTextBox_Leave;

            tbContent.PreviewKeyDown += textBox_PreviewKeyDown;
            tbContent.KeyDown += textBox_KeyDown;

            ForeColorChanged += CTextBox_ForeColorChanged;
        }

        private void CTextBox_ForeColorChanged(object? sender, EventArgs e)
        {
            tbContent.ForeColor = ForeColor;
        }

        private void textBox_PreviewKeyDown(object? sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true; // mark Tab as input
            }
        }

        private void textBox_KeyDown(object? sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox) sender;

            if (e.KeyCode == Keys.Tab)
            {
                int pos = textBox.SelectionStart;
                //textBox.Text = textBox.Text.Insert(pos, "    ");
                textBox.SelectionStart = pos + 4;
                e.Handled = true;
            }
        }

        private void CTextBox_Leave(object? sender, EventArgs e)
        {
            currentBorderColor = borderColor;
            Invalidate();
        }

        private void CTextBox_Enter(object? sender, EventArgs e)
        {
            currentBorderColor = highlightBorderColor;
            Invalidate();
        }

        private void CTextBox_SizeChanged(object? sender, EventArgs e)
        {
            Width = tbContent.Width + Padding.Left + Padding.Right;
            Height = tbContent.Height + Padding.Top + Padding.Bottom;

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using var pen = new Pen(currentBorderColor, borderThickness);
            var path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(tbContent.Left - Padding.Left / 2 - borderThickness, tbContent.Top - Padding.Top / 2 - borderThickness, borderThickness * 2, borderThickness * 2, 180, 90);
            path.AddArc(tbContent.Right + Padding.Right / 2 - borderThickness, tbContent.Top - Padding.Top / 2 - borderThickness, borderThickness * 2, borderThickness * 2, 270, 90);
            path.AddArc(tbContent.Right + Padding.Right / 2 - borderThickness, tbContent.Bottom + Padding.Bottom / 2 - borderThickness, borderThickness * 2, borderThickness * 2, 0, 90);
            path.AddArc(tbContent.Left - Padding.Left / 2 - borderThickness, tbContent.Bottom + Padding.Bottom / 2 - borderThickness, borderThickness * 2, borderThickness * 2, 90, 90);
            path.CloseFigure();

            g.DrawPath(pen, path);
        }
    }
}
