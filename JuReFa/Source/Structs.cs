using System.Drawing;

namespace JuReFa.Source
{
    internal struct IWindowSize
    {
        public int Height;
        public int Width;
        public IWindowSize(int _Height, int _Width)
        {
            Height = _Height > 0 ? _Height : 0;
            Width = _Width > 0 ? _Width : 0;
        }
    }
    internal struct IColors
    {
        public static Color Pink = Color.FromArgb(254, 107, 107);
        public static Color Gray = Color.FromArgb(70, 70, 70);
        public static Color Defautl = Color.LightBlue;
    }

}
