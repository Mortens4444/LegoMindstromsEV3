using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Mindstorms.Core.Drawing
{
    public class EV3InverseRectangle : IEV3DrawingElement
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        public EV3Point TopLeftCorner { get; }

        public byte Width { get; }

        public byte Height { get; }

        public Panel ParentControl { get; }

        public EV3InverseRectangle(EV3Point point, byte width, byte height, Panel parentControl)
            : this(point.X, point.Y, width, height, parentControl)
        { }

        public EV3InverseRectangle(byte x, byte y, byte width, byte height, Panel parentControl)
        {
            TopLeftCorner = new EV3Point(x, y);
            Width = width;
            Height = height;
            ParentControl = parentControl;
        }

        public void DrawOnGraphics(Graphics graphics)
        {
            DrawOnGraphics(graphics, Color.Black);
        }

        public void DrawOnGraphics(Graphics graphics, Color color)
        {
            for (int x = TopLeftCorner.X; x < TopLeftCorner.X + Width; x++)
            {
                for (int y = TopLeftCorner.Y; y < TopLeftCorner.Y + Height; y++)
                {
                    var hdc = GetDC(ParentControl.Handle);
                    var pixel = GetPixel(hdc, x, y);
                    ReleaseDC(ParentControl.Handle, hdc);
                    var pixelColor = Color.FromArgb((int)(pixel & 0x000000FF), (int)(pixel & 0x0000FF00) >> 8, (int)(pixel & 0x00FF0000) >> 16);
                    var inverseColor = pixelColor.ToArgb() == Color.Black.ToArgb() ? Color.CadetBlue : Color.Black;
                    graphics.FillRectangle(new SolidBrush(inverseColor), x, y, 1, 1);
                }
            }
        }
    }
}
