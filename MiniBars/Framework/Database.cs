namespace MiniBars.Framework
{
    internal class Database
    {
        internal static string BarTheme { get; private set; }
        internal static int DistanceX { get; private set; }
        internal static int BarSize { get; private set; }

        public static void SetThemeForConfig()
        {
            if (ModEntry.config.Bars_Theme == 2)
            {
                BarTheme = "Simple_Themes";
                DistanceX = 15;
                BarSize = 31;
            }
            else
            {
                BarTheme = "Normal_Themes";
                DistanceX = 4;
                BarSize = 20;
            }
        }
    }
}
