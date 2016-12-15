using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Update
{
    /// <summary>
    /// Material design-like Process bar
    /// </summary>
    public partial class MaterialProcessBar : ProgressBar
    {
        private System.Windows.Forms.Timer RenderTimer = new System.Windows.Forms.Timer() { };

        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialProcessBar"/> class.
        /// </summary>
        public MaterialProcessBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            RenderTimer.Tick += new EventHandler(RenderTimer_Tick);
            RenderTimer.Interval = Interval;
            RenderTimer.Enabled = Processing;
            //IsCreated = true;
        }

        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            if (Processing && !IsPercent)
            {
                int i = Value;
                i += StepValue;
                if (i >= Width)
                    i = -LengthValue;
                Value = i;
                Invalidate();
            }
        }

        public new int Value;
        private int value
        {
            get
            {
                return Value;
            }

            set
            {
                Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the depth.
        /// </summary>
        /// <value>
        /// The depth.
        /// </value>
        [Browsable(false)]
        public int Depth { get; set; }

        private int stepValue = 5;
        public int StepValue
        {
            get
            {
                return stepValue;
            }

            set
            {
                stepValue = value;
            }
        }

        private int lengthValue = 10;
        public int LengthValue
        {
            get
            {
                return lengthValue;
            }

            set
            {
                lengthValue = value;
            }
        }

        private bool processing = false;
        public bool Processing
        {
            get
            {
                return processing;
            }

            set
            {
                processing = value;
                //Visible = Processing;
                RenderTimer.Enabled = Processing;
            }
        }

        private int interval = 10;
        public int Interval
        {
            get
            {
                return interval;
            }

            set
            {
                interval = value;
                RenderTimer.Interval = Interval;
            }
        }

        private bool isPercent = false;
        public bool IsPercent
        {
            get
            {
                return isPercent;
            }

            set
            {
                isPercent = value;
                Invalidate();
            }
        }

        private double percentValue = 0.5;
        public double PercentValue
        {
            get
            {
                return percentValue;
            }

            set
            {
                if (value < 0)
                    value = 0;
                if (value > 1)
                    value = 1;
                percentValue = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Performs the work of setting the specified bounds of this control.
        /// </summary>
        /// <param name="x">The new <see cref="P:System.Windows.Forms.Control.Left" /> property value of the control.</param>
        /// <param name="y">The new <see cref="P:System.Windows.Forms.Control.Top" /> property value of the control.</param>
        /// <param name="width">The new <see cref="P:System.Windows.Forms.Control.Width" /> property value of the control.</param>
        /// <param name="height">The new <see cref="P:System.Windows.Forms.Control.Height" /> property value of the control.</param>
        /// <param name="specified">A bitwise combination of the <see cref="T:System.Windows.Forms.BoundsSpecified" /> values.</param>
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, 5, specified);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                if (IsPercent)
                {
                    var doneProgress = (int)(e.ClipRectangle.Width * percentValue);
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(55, 71, 79)), 0, 0, doneProgress, e.ClipRectangle.Height);
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(66, 0, 0, 0)), doneProgress, 0, e.ClipRectangle.Width, e.ClipRectangle.Height);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(66, 0, 0, 0)), 0, 0, e.ClipRectangle.Width, e.ClipRectangle.Height);
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(55, 71, 79)), Value, 0, LengthValue, e.ClipRectangle.Height);
                }
            }
            catch { }
        }

    }
}
