using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ITDeviceManager
{
    public static class ThemeColors
    {
        public static Color Background(AppTheme theme) =>
            theme == AppTheme.Dark
                ? Color.FromArgb(15, 18, 24)
                : Color.FromArgb(245, 247, 250);

        public static Color Surface(AppTheme theme) =>
            theme == AppTheme.Dark
                ? Color.FromArgb(24, 28, 36)
                : Color.White;

        public static Color SurfaceSecondary(AppTheme theme) =>
            theme == AppTheme.Dark
                ? Color.FromArgb(31, 36, 46)
                : Color.FromArgb(238, 241, 245);

        public static Color TextPrimary(AppTheme theme) =>
            theme == AppTheme.Dark
                ? Color.FromArgb(242, 244, 247)
                : Color.FromArgb(25, 29, 35);

        public static Color TextSecondary(AppTheme theme) =>
            theme == AppTheme.Dark
                ? Color.FromArgb(160, 169, 184)
                : Color.FromArgb(100, 110, 125);

        public static Color Border(AppTheme theme) =>
            theme == AppTheme.Dark
                ? Color.FromArgb(48, 54, 66)
                : Color.FromArgb(220, 224, 230);

        public static Color Accent(AppTheme theme) =>
            Color.FromArgb(55, 125, 255);

        public static Color Success(AppTheme theme) =>
            Color.FromArgb(45, 170, 100);

        public static Color Warning(AppTheme theme) =>
            Color.FromArgb(235, 165, 45);

        public static Color Danger(AppTheme theme) =>
            Color.FromArgb(220, 75, 75);

        public static Color Unverified(AppTheme theme) =>
            Color.FromArgb(145, 105, 220);
    }
}
