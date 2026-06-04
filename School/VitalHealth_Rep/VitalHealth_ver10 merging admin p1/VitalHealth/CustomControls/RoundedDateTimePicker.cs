using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VitalHealth.CustomControls
{
    public class RoundedDateTimePicker : UserControl
    {
        private int borderRadius = 20;
        private Color borderColor = Color.Gray;
        private DateTimePicker dtp = new DateTimePicker();

        // ----- Properties -----
        [Category("Custom")]
        [Description("Sets the corner radius of the control.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate(); // redraw control
            }
        }

        [Category("Custom")]
        [Description("Sets the border color of the control.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom")]
        [Description("Gets or sets the selected date value.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public DateTime Value
        {
            get { return dtp.Value; }
            set { dtp.Value = value; }
        }

        // Optional: Expose Font and ForeColor for the inner DateTimePicker
        [Category("Custom")]
        public override Font Font
        {
            get { return dtp.Font; }
            set { dtp.Font = value; base.Font = value; this.Invalidate(); }
        }

        [Category("Custom")]
        public override Color ForeColor
        {
            get { return dtp.ForeColor; }
            set { dtp.ForeColor = value; base.ForeColor = value; dtp.ForeColor = value; }
        }

        // ----- Constructor -----
        public RoundedDateTimePicker()
        {
            this.Size = new Size(200, 40);
            this.BackColor = Color.White;
            this.ResizeRedraw = true;

            dtp.Format = DateTimePickerFormat.Short;
            dtp.Location = new Point(10, 10);
            dtp.Width = this.Width - 20;
            dtp.Height = this.Height - 20;

            this.Controls.Add(dtp);
        }

        // ----- Painting -----
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            using (GraphicsPath path = GetRoundedRect(rect, borderRadius))
            {
                using (Pen pen = new Pen(borderColor, 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            dtp.Width = this.Width - 20;
            dtp.Height = this.Height - 20;
            dtp.Location = new Point(10, 10);
            this.Invalidate();
        }
    }
}