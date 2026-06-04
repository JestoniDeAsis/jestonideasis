using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VitalHealth
{
    public class RoundedButton : Button
    {
        public int BorderRadius = 20;
        public Color TextColor = Color.White;

        private bool isHovered = false;
        private bool isPressed = false;

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            ForeColor = TextColor;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = Height;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            Region = new Region(path);

            Color currentColor = BackColor;

            bool dark = IsDark(BackColor);

            if (isPressed)
            {
                currentColor = dark
                    ? Lighten(BackColor, 0.20f)   // dark base → make lighter
                    : Darken(BackColor, 0.20f);   // light base → make darker
            }
            else if (isHovered)
            {
                currentColor = dark
                    ? Lighten(BackColor, 0.10f)
                    : Darken(BackColor, 0.10f);
            }

            using (SolidBrush brush = new SolidBrush(currentColor))
            {
                pevent.Graphics.FillPath(brush, path);
            }

            TextRenderer.DrawText(
                pevent.Graphics,
                Text,
                Font,
                ClientRectangle,
                TextColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }

        private Color Darken(Color color, float factor)
        {
            // factor: 0.0 = black, 1.0 = original color
            int r = (int)(color.R * factor);
            int g = (int)(color.G * factor);
            int b = (int)(color.B * factor);

            return Color.FromArgb(color.A, r, g, b);
        }
        private bool IsDark(Color color)
        {
            // Standard luminance formula
            double brightness =
                (0.299 * color.R) +
                (0.587 * color.G) +
                (0.114 * color.B);

            return brightness < 140; // threshold (you can adjust)
        }
        private Color Lighten(Color color, float factor)
        {
            int r = (int)(color.R + (255 - color.R) * factor);
            int g = (int)(color.G + (255 - color.G) * factor);
            int b = (int)(color.B + (255 - color.B) * factor);

            return Color.FromArgb(color.A, r, g, b);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            isPressed = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            isPressed = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            isPressed = false;
            Invalidate();
        }
    }
}