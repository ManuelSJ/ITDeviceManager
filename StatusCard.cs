using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace ITDeviceManager
{
    public partial class StatusCard : UserControl
    {
        private string cardTitle = "Título";
        private string cardValue = "0";

        private StatusCardType cardType = StatusCardType.Neutral;

        public StatusCard()
        {
            InitializeComponent();

            DoubleBuffered = true;
            ApplyTheme();
            UpdateRoundedRegion();
        }

        [Category("ITDeviceManager")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string CardTitle
        {
            get => cardTitle;
            set
            {
                cardTitle = value;
                Invalidate();
            }
        }

        [Category("ITDeviceManager")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string CardValue
        {
            get => cardValue;
            set
            {
                cardValue = value;
                Invalidate();
            }
        }

        [Category("ITDeviceManager")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public StatusCardType CardType
        {
            get => cardType;
            set
            {
                cardType = value;
                Invalidate();
            }
        }

        public void ApplyTheme()
        {
            BackColor = ThemeColors.Surface(ThemeManager.CurrentTheme);
            ForeColor = ThemeColors.TextPrimary(ThemeManager.CurrentTheme);

            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle cardRectangle = new Rectangle(
                0,
                0,
                Width - 1,
                Height - 1
            );

            using GraphicsPath cardPath = CreateRoundedRectangle(
                cardRectangle,
                14
            );

            Color statusColor = GetStatusColor();

            bool hasValue = int.TryParse(CardValue, out int value) && value > 0;

            Color backgroundColor = hasValue
                ? statusColor
                : ThemeColors.Surface(ThemeManager.CurrentTheme);

            double brightness =
                 (backgroundColor.R * 299 +
                 backgroundColor.G * 587 +
                  backgroundColor.B * 114) / 1000.0;

            Color textColor = brightness < 140
                ? Color.White
                : Color.Black;


            using SolidBrush backgroundBrush =
                new SolidBrush(backgroundColor);

            using Pen borderPen =
                new Pen(ThemeColors.Border(ThemeManager.CurrentTheme), 1);

            e.Graphics.FillPath(backgroundBrush, cardPath);
            e.Graphics.DrawPath(borderPen, cardPath);

            using SolidBrush indicatorBrush = new SolidBrush(statusColor);

            e.Graphics.FillEllipse(
                indicatorBrush,
                18,
                18,
                10,
                10
            );

            using Font titleFont = new Font(
                Font.FontFamily,
                10,
                FontStyle.Bold
            );

            using Font valueFont = new Font(
                Font.FontFamily,
                24,
                FontStyle.Bold
            );

            using SolidBrush titleBrush = new SolidBrush(textColor);

            using SolidBrush valueBrush = new SolidBrush(textColor);

            e.Graphics.DrawString(
                CardTitle,
                titleFont,
                titleBrush,
                36,
                14
            );

            e.Graphics.DrawString(
                CardValue,
                valueFont,
                valueBrush,
                18,
                45
            );
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            UpdateRoundedRegion();
        }

        private void UpdateRoundedRegion()
        {
            if (Width <= 0 || Height <= 0)
                return;

            Rectangle bounds = new Rectangle(
                0,
                0,
                Width - 1,
                Height - 1
            );

            using GraphicsPath path = CreateRoundedRectangle(bounds, 14);

            Region?.Dispose();
            Region = new Region(path);

            Invalidate();
        }

        private static GraphicsPath CreateRoundedRectangle(
           Rectangle bounds,
            int radius)
        {
            int diameter = radius * 2;

            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();

            return path;
        }

        private Color GetStatusColor()
        {
            AppTheme theme = ThemeManager.CurrentTheme;

            return CardType switch
            {
                StatusCardType.Success => ThemeColors.Success(theme),
                StatusCardType.Warning => ThemeColors.Warning(theme),
                StatusCardType.Danger => ThemeColors.Danger(theme),
                StatusCardType.Unverified => ThemeColors.Unverified(theme),
                _ => ThemeColors.Accent(theme)
            };
        }

    }
}
