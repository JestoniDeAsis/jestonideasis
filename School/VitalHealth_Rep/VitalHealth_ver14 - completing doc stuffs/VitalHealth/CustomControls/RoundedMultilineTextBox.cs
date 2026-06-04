using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VitalHealth
{
    public class RoundedMultilineTextBox : UserControl
    {
        private readonly TextBox textBox;

        private int borderRadius = 20;
        private int borderSize = 2;
        private bool hovered = false;
        private bool focused = false;

        private Padding textPadding = new Padding(14, 12, 14, 12);

        private Color baseColor = Color.White;
        private Color borderColor = Color.FromArgb(200, 200, 200);
        private Color hoverBorderColor = Color.FromArgb(170, 170, 170);
        private Color focusBorderColor = Color.FromArgb(100, 100, 100);

        public RoundedMultilineTextBox()
        {
            DoubleBuffered = true;
            Size = new Size(350, 140);

            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true
            );

            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Multiline = true,
                AcceptsReturn = true,
                ScrollBars = ScrollBars.Vertical,
                Font = base.Font,
                BackColor = baseColor,
                ForeColor = Color.Black
            };

            textBox.GotFocus += TextBox_GotFocus;
            textBox.LostFocus += TextBox_LostFocus;
            textBox.MouseEnter += TextBox_MouseEnter;
            textBox.MouseLeave += TextBox_MouseLeave;
            textBox.TextChanged += (s, e) => OnTextChanged(e);

            Controls.Add(textBox);

            Click += (s, e) => textBox.Focus();
            Resize += (s, e) => UpdateTextBoxBounds();

            UpdateTextBoxBounds();
        }

        private void TextBox_GotFocus(object? sender, EventArgs e)
        {
            focused = true;
            Invalidate();
        }

        private void TextBox_LostFocus(object? sender, EventArgs e)
        {
            focused = false;
            Invalidate();
        }

        private void TextBox_MouseEnter(object? sender, EventArgs e)
        {
            hovered = true;
            Invalidate();
        }

        private void TextBox_MouseLeave(object? sender, EventArgs e)
        {
            hovered = false;
            Invalidate();
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(20)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value < 1 ? 1 : value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(2)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value < 1 ? 1 : value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BaseColor
        {
            get => baseColor;
            set
            {
                baseColor = value;
                textBox.BackColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HoverBorderColor
        {
            get => hoverBorderColor;
            set
            {
                hoverBorderColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color FocusBorderColor
        {
            get => focusBorderColor;
            set
            {
                focusBorderColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color TextColor
        {
            get => textBox.ForeColor;
            set => textBox.ForeColor = value;
        }

        [Browsable(true)]
        [Category("Layout")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Padding TextPadding
        {
            get => textPadding;
            set
            {
                textPadding = value;
                UpdateTextBoxBounds();
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        public string PlaceholderText
        {
            get => textBox.PlaceholderText;
            set => textBox.PlaceholderText = value ?? string.Empty;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => textBox.Text;
            set => textBox.Text = value ?? string.Empty;
        }

        [Browsable(true)]
        [Category("Appearance")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                textBox.Font = value;
                UpdateTextBoxBounds();
            }
        }

        [Browsable(true)]
        [Category("Behavior")]
        [DefaultValue(false)]
        public bool ReadOnly
        {
            get => textBox.ReadOnly;
            set => textBox.ReadOnly = value;
        }

        [Browsable(true)]
        [Category("Behavior")]
        [DefaultValue(true)]
        public bool Multiline
        {
            get => textBox.Multiline;
            set => textBox.Multiline = value;
        }

        [Browsable(true)]
        [Category("Behavior")]
        [DefaultValue(true)]
        public bool AcceptsReturn
        {
            get => textBox.AcceptsReturn;
            set => textBox.AcceptsReturn = value;
        }

        [Browsable(true)]
        [Category("Behavior")]
        [DefaultValue(ScrollBars.Vertical)]
        public ScrollBars ScrollBars
        {
            get => textBox.ScrollBars;
            set => textBox.ScrollBars = value;
        }

        private void UpdateTextBoxBounds()
        {
            textBox.Location = new Point(textPadding.Left, textPadding.Top);
            textBox.Size = new Size(
                Width - textPadding.Left - textPadding.Right,
                Height - textPadding.Top - textPadding.Bottom
            );
        }

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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color currentBorderColor = borderColor;

            if (focused)
                currentBorderColor = focusBorderColor;
            else if (hovered)
                currentBorderColor = hoverBorderColor;

            using (GraphicsPath path = GetRoundedPath())
            using (SolidBrush brush = new SolidBrush(baseColor))
            using (Pen pen = new Pen(currentBorderColor, borderSize))
            {
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(pen, path);
                Region = new Region(path);
            }
        }

        private GraphicsPath GetRoundedPath()
        {
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            int radius = borderRadius;

            if (radius > Height)
                radius = Height;

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