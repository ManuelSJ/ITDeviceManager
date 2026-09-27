using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace ITDeviceManager
{
    public class ModernProgressBar : Control
    {
        private int _value = 0;

        [DefaultValue(0)]
        public int Value
        {
            get => _value;
            set
            {
                _value = Math.Max(0, Math.Min(100, value));
                Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "46, 174, 95")]
        public Color ProgressColor { get; set; } = Color.FromArgb(46, 174, 95);

        [DefaultValue(typeof(Color), "225, 230, 235")]
        public Color TrackColor { get; set; } = Color.FromArgb(225, 230, 235);


        public ModernProgressBar()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);

            Height = 8;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = Height / 2;

            using GraphicsPath trackPath = CreateRoundedPath(
                new Rectangle(0, 0, Width - 1, Height - 1),
                radius);

            using SolidBrush trackBrush = new SolidBrush(TrackColor);

            e.Graphics.FillPath(trackBrush, trackPath);

            int progressWidth = (int)(Width * (_value / 100f));

            if (progressWidth > 0)
            {
                using GraphicsPath progressPath = CreateRoundedPath(
                    new Rectangle(0, 0, progressWidth, Height - 1),
                    radius);

                using SolidBrush progressBrush = new SolidBrush(ProgressColor);

                e.Graphics.FillPath(progressBrush, progressPath);
            }
        }

        private GraphicsPath CreateRoundedPath(Rectangle rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;

            path.AddArc(rectangle.X, rectangle.Y, diameter, diameter, 180, 90);
            path.AddArc(rectangle.Right - diameter, rectangle.Y, diameter, diameter, 270, 90);
            path.AddArc(rectangle.Right - diameter, rectangle.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rectangle.X, rectangle.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();

            return path;
        }
    }
}