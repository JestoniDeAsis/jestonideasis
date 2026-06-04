using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VitalHealth.CustomControls
{
    public class LessRoundedPanel : Panel
    {
        private int borderRadius = 12;

        [Category("Custom")]
        [Description("Sets the radius of the panel corners.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate(); // Redraw when value changes
            }
        }

        public LessRoundedPanel()
        {
            this.ResizeRedraw = true; // Redraw when resized
            this.BackColor = Color.White; // Default background
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Get rounded rectangle path
            GraphicsPath path = GetRoundedRectangle(this.ClientRectangle, borderRadius);

            // Set the region to get rounded corners
            this.Region = new Region(path);

            // Fill the background
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // top-left
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // top-right
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // bottom-right
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // bottom-left
            path.CloseFigure();

            return path;
        }
    }
}