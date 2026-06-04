using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VitalHealth
{
    public class RoundedComboBox : ComboBox
    {
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

        private Color BaseColor;
        private Color BorderColor;
        private Color HoverBorderColor;
        private Color FocusBorderColor;

        private int borderRadius = 20;
        private bool hovered = false;
        private bool focused = false;

        private string placeholderText = "Select";

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue("Select")]
        public string PlaceholderText
        {
            get => placeholderText;
            set
            {
                placeholderText = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(20)]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                UpdateRegion();
                Invalidate();
            }
        }

        // =========================
        // CONSTRUCTOR
        // =========================

        public RoundedComboBox()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);

            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
            IntegralHeight = false;

            ApplyTheme();
            UpdateRegion();

            Resize += (s, e) => UpdateRegion();

            GotFocus += (s, e) => { focused = true; Invalidate(); };
            LostFocus += (s, e) => { focused = false; Invalidate(); };
            MouseEnter += (s, e) => { hovered = true; Invalidate(); };
            MouseLeave += (s, e) => { hovered = false; Invalidate(); };
        }

        // =========================
        // THEME
        // =========================

        private void ApplyTheme()
        {
            if (theme == ControlTheme.Dark)
            {
                BaseColor = ColorTranslator.FromHtml("#292929");
                BorderColor = Color.FromArgb(60, 60, 60);
                HoverBorderColor = Color.FromArgb(90, 90, 90);
                FocusBorderColor = Color.FromArgb(120, 120, 120);
                ForeColor = Color.White;
            }
            else
            {
                BaseColor = Color.White;
                BorderColor = Color.FromArgb(200, 200, 200);
                HoverBorderColor = Color.FromArgb(170, 170, 170);
                FocusBorderColor = Color.FromArgb(100, 100, 100);
                ForeColor = Color.Black;
            }

            BackColor = BaseColor;
        }

        // =========================
        // ROUND REGION
        // =========================

        private void UpdateRegion()
        {
            if (Width <= 0 || Height <= 0) return;

            using (GraphicsPath path = GetRoundPath())
            {
                Region = new Region(path);
            }
        }

        private GraphicsPath GetRoundPath()
        {
            int radius = BorderRadius;
            Rectangle rect = new Rectangle(0, 0, Width, Height);

            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);

            path.CloseFigure();
            return path;
        }

        // =========================
        // DRAW ITEMS
        // =========================

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            Color textColor = (theme == ControlTheme.Dark) ? Color.White : Color.Black;

            using (SolidBrush brush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(
                    Items[e.Index].ToString(),
                    Font,
                    brush,
                    e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        // =========================
        // PAINT CONTROL
        // =========================

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Color border = BorderColor;

            if (focused)
                border = FocusBorderColor;
            else if (hovered)
                border = HoverBorderColor;

            using (GraphicsPath path = GetRoundPath())
            using (SolidBrush brush = new SolidBrush(BaseColor))
            using (Pen pen = new Pen(border, 2))
            {
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(pen, path);
            }

            // =========================
            // CENTERED TEXT
            // =========================

            string textToDraw = SelectedIndex == -1 ? placeholderText : Text;

            Color textColor = SelectedIndex == -1
                ? Color.Gray
                : ForeColor;

            // Create full client rectangle
            Rectangle textRect = ClientRectangle;

            // Remove border spacing
            textRect.Inflate(-10, 0);

            TextRenderer.DrawText(
                e.Graphics,
                textToDraw,
                Font,
                textRect,
                textColor,
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.Left |
                TextFormatFlags.EndEllipsis);
        }

        // =========================
        // RESIZE
        // =========================

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }
    }
}