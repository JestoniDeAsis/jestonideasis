using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VitalHealth
{
    public class SquareRadioButton : UserControl
    {
        private bool isChecked = false;
        private bool hovered = false;

        // =========================
        // PROPERTIES
        // =========================

        [Browsable(true)]
        [Category("Behavior")]
        [DefaultValue(false)]
        public bool Checked
        {
            get => isChecked;
            set
            {
                if (isChecked != value)
                {
                    isChecked = value;

                    if (isChecked)
                        UncheckOtherRadios();

                    Invalidate();
                    OnCheckedChanged(EventArgs.Empty);
                }
            }
        }

        public event EventHandler CheckedChanged;

        protected virtual void OnCheckedChanged(EventArgs e)
        {
            CheckedChanged?.Invoke(this, e);
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue("TextHere")]
        public string Label
        {
            get => this.Text;
            set
            {
                this.Text = value;
                Invalidate();
            }
        }

        // =========================
        // COLORS (DARK ONLY)
        // =========================

        public Color BackColorNormal = Color.White;
        public Color BorderColor = ColorTranslator.FromHtml("#292929");
        public Color HoverBorderColor = Color.FromArgb(110, 110, 110);
        public Color CheckedColor = Color.LimeGreen;

        // =========================
        // CONSTRUCTOR
        // =========================

        public SquareRadioButton()
        {
            DoubleBuffered = true;
            Height = 28;
            Cursor = Cursors.Hand;

            this.Click += (s, e) => Toggle();
        }

        private void Toggle()
        {
            Checked = true; // behaves like radio button
        }

        // Uncheck other radios in same container
        private void UncheckOtherRadios()
        {
            if (Parent == null) return;

            foreach (Control ctrl in Parent.Controls)
            {
                if (ctrl is SquareRadioButton radio && radio != this)
                {
                    radio.isChecked = false;
                    radio.Invalidate();
                }
            }
        }

        // =========================
        // MOUSE EVENTS
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

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Checked = true;
        }

        // =========================
        // PAINT
        // =========================

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int boxSize = 18;
            Rectangle box = new Rectangle(0, (Height - boxSize) / 2, boxSize, boxSize);

            Color border = BorderColor;

            if (hovered)
                border = HoverBorderColor;

            using (SolidBrush backBrush = new SolidBrush(BackColorNormal))
            using (Pen pen = new Pen(border, 2))
            {
                // Draw square
                e.Graphics.FillRectangle(backBrush, box);
                e.Graphics.DrawRectangle(pen, box);
            }

            // Draw green fill if checked
            if (isChecked)
            {
                Rectangle inner = new Rectangle(box.X + 4, box.Y + 4, box.Width - 8, box.Height - 8);

                using (SolidBrush greenBrush = new SolidBrush(CheckedColor))
                {
                    e.Graphics.FillRectangle(greenBrush, inner);
                }
            }

            // Draw text
            using (SolidBrush textBrush = new SolidBrush(ForeColor))
            {
                e.Graphics.DrawString(
                    Text,
                    Font,
                    textBrush,
                    box.Right + 8,
                    (Height - Font.Height) / 2
                );
            }
        }
    }
}