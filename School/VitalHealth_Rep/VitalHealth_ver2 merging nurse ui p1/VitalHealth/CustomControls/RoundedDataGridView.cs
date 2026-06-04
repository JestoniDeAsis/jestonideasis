using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VitalHealth.CustomControls
{
    public class RoundedDataGridView : UserControl
    {
        private DataGridView dgvMain = new DataGridView();
        private int borderRadius = 20;
        private Color borderColor = Color.Gray;
        private int borderThickness = 2;

        [Category("Custom")]
        [Description("Sets the corner radius of the DataGridView.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        private Color alternatingRowColor = Color.FromArgb(220, 240, 220);
        private Color selectionColor = Color.FromArgb(0, 120, 215);

        [Category("Custom")]
        [Description("Sets the border color of the DataGridView.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("Custom")]
        [Description("Sets the thickness of the border.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderThickness
        {
            get { return borderThickness; }
            set { borderThickness = value; this.Invalidate(); }
        }

        public RoundedDataGridView()
        {
            this.Size = new Size(700, 300);
            this.BackColor = Color.White;
            this.ResizeRedraw = true;

            dgvMain.Location = new Point(10, 10); // inside the UserControl
            dgvMain.Size = new Size(this.Width - 20, this.Height - 20); // leave padding for border
            dgvMain.BorderStyle = BorderStyle.None;
            dgvMain.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMain.EnableHeadersVisualStyles = false;

            // Header style
            dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvMain.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvMain.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvMain.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvMain.ColumnHeadersHeight = 35;

            // Row style
            dgvMain.RowTemplate.Height = 35;
            dgvMain.RowsDefaultCellStyle.BackColor = Color.White;
            dgvMain.AlternatingRowsDefaultCellStyle.BackColor = alternatingRowColor;
            dgvMain.DefaultCellStyle.SelectionBackColor = selectionColor;
            dgvMain.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMain.DefaultCellStyle.Padding = new Padding(5);

            // Behavior
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.MultiSelect = false;
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.RowHeadersVisible = false;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.Controls.Add(dgvMain);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            using (GraphicsPath path = GetRoundedRect(rect, borderRadius))
            using (Pen pen = new Pen(borderColor, borderThickness))
            {
                e.Graphics.DrawPath(pen, path);
                this.Region = new Region(path); // clip everything inside rounded corners
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
            // Keep padding of 10 pixels from all sides
            dgvMain.Location = new Point(10, 10);
            dgvMain.Size = new Size(this.Width - 20, this.Height - 20);
            this.Invalidate();
        }

        // Optional: expose dgvMain for data binding
        [Browsable(false)]
        public DataGridView Grid
        {
            get { return dgvMain; }
        }
    }
}