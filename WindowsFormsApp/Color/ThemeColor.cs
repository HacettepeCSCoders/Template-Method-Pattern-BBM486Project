using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp
{
    public class ThemeColor
    { 
        public static List<string> ColorList = new List<string>()
        {
            "#6B8E23",
            "#7FFF00",
            "#B0C4DE",
            "#00FF00",
            "#708090",
            "#483D8B",
            "#FFC0CB",
            "#808080",
            "#FA8072",
            "#C0C0C0",
            "#7FFFD4",
            "#1E90FF",
            "#E9967A",
            "#4169E1"
        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor<0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte) red, (byte) green, (byte) blue);
        }
    }
}