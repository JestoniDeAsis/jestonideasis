using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VitalHealth
{
    public enum ControlTheme
    {
        Dark,
        Light
    }

    public class RoundedTextBox : UserControl
    {
        private TextBox textBox = new TextBox();

        // =========================
        // THEME
        // =========================

        private ControlTheme theme = ControlTheme.Dark;

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(ControlTheme.Dark)]
        public ControlTheme Theme
        {
            get => theme;
            set
            {
                theme = value;
                ApplyTheme();
                Invalidate();
            }
        }

        // =========================
        // APPEARANCE
        // =========================

        public Color BaseColor = ColorTranslator.FromHtml("#292929");
        public Color BorderColor = Color.FromArgb(60, 60, 60);
        public Color HoverBorderColor = Color.FromArgb(90, 90, 90);
        public Color FocusBorderColor = Color.FromArgb(120, 120, 120);

        public int BorderSize = 2;

        private bool hovered = false;
        private bool focused = false;

        // =========================
        // PLACEHOLDER
        // =========================

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        public string PlaceholderText
        {
            get => textBox.PlaceholderText;
            set => textBox.PlaceholderText = value;
        }

        // =========================
        // TEXT
        // =========================

        [Browsable(true)]
        public override string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        // =========================
        // READ ONLY
        // =========================

        [Browsable(true)]
        [Category("Behavior")]
        [DefaultValue(false)]
        public bool ReadOnly
        {
            get => textBox.ReadOnly;
            set => textBox.ReadOnly = value;
        }

        // =========================
        // PASSWORD
        // =========================

        [Browsable(true)]
        [Category("Behavior")]
        [DefaultValue(false)]
        public bool UseSystemPasswordChar
        {
            get => textBox.UseSystemPasswordChar;
            set => textBox.UseSystemPasswordChar = value;
        }

        // =========================
        // TEXT PADDING
        // =========================

        private Padding textPadding = new Padding(12, 0, 12, 0);

        [Browsable(true)]
        [Category("Layout")]
        [DefaultValue(typeof(Padding), "12, 0, 12, 0")]
        public Padding TextPadding
        {
            get => textPadding;
            set
            {
                textPadding = value;
                UpdateTextBoxBounds();
            }
        }

        // =========================
        // CONSTRUCTOR
        // =========================

        public RoundedTextBox()
        {
            DoubleBuffered = true;
            Height = 40;

            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);

            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = this.Font;
            textBox.Multiline = false;
            textBox.ScrollBars = ScrollBars.None;

            textBox.GotFocus += (s, e) =>
            {
                focused = true;
                Invalidate();
            };

            textBox.LostFocus += (s, e) =>
            {
                focused = false;
                Invalidate();
            };

            Controls.Add(textBox);

            this.Click += (s, e) => textBox.Focus();

            this.FontChanged += (s, e) =>
            {
                textBox.Font = this.Font;
                UpdateTextBoxBounds();
            };

            ApplyTheme();
            UpdateTextBoxBounds();
        }

        // =========================
        // THEME APPLIER
        // =========================

        private void ApplyTheme()
        {
            if (theme == ControlTheme.Dark)
            {
                BaseColor = ColorTranslator.FromHtml("#292929");
                BorderColor = Color.FromArgb(60, 60, 60);
                HoverBorderColor = Color.FromArgb(90, 90, 90);
                FocusBorderColor = Color.FromArgb(120, 120, 120);
                textBox.ForeColor = Color.White;
            }
            else // Light
            {
                BaseColor = Color.White;
                BorderColor = Color.FromArgb(200, 200, 200);
                HoverBorderColor = Color.FromArgb(170, 170, 170);
                FocusBorderColor = Color.FromArgb(100, 100, 100);
                textBox.ForeColor = Color.Black;
            }

            textBox.BackColor = BaseColor;
        }

        // =========================
        // RESIZE
        // =========================

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateTextBoxBounds();
        }

        private void UpdateTextBoxBounds()
        {
            if (textBox == null) return;

            textBox.Location = new Point(
                TextPadding.Left,
                (Height - textBox.Font.Height) / 2
            );

            textBox.Width = Width - TextPadding.Left - TextPadding.Right;
        }

        // =========================
        // HOVER
        // =========================

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            hovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            hovered = false;
            Invalidate();
        }

        // =========================
        // PAINT
        // =========================

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = Height;

            Color border = BorderColor;

            if (focused)
                border = FocusBorderColor;
            else if (hovered)
                border = HoverBorderColor;

            using (GraphicsPath path = GetPath(radius))
            using (SolidBrush brush = new SolidBrush(BaseColor))
            using (Pen pen = new Pen(border, BorderSize))
            {
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(pen, path);
                Region = new Region(path);
            }
        }

        // =========================
        // ROUND PATH
        // =========================

        private GraphicsPath GetPath(int radius)
        {
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);

            path.CloseFigure();

            return path;
        }
    }
}