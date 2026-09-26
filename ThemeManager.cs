using System;
using System.Collections.Generic;
using System.Text;

namespace ITDeviceManager
{
    public static class ThemeManager
    {
        public static AppTheme CurrentTheme { get; private set; } = AppTheme.Light;

        public static void SetTheme(AppTheme theme)
        {
            CurrentTheme = theme;
        }

        public static void ToggleTheme()
        {
            CurrentTheme = CurrentTheme == AppTheme.Light
                ? AppTheme.Dark
                : AppTheme.Light;
        }
    }
}