using System.Drawing;

namespace Mindstorms.Core.Drawing
{
    public class EV3Rectangle : IEV3DrawingElement
    {
        public EV3Point TopLeftCorner { get; }

        public byte Width { get; }

        public byte Height { get; }

        public bool Fill { get; }

        public EV3Rectangle(EV3Point point, byte width, byte height, bool fill)
            : this(point.X, point.Y, width, height, fill)
        { }

        public EV3Rectangle(byte x, byte y, byte width, byte height, bool fill)
        {
            TopLeftCorner = new EV3Point(x, y);
            Width = width;
            Height = height;
            Fill = fill;
        }

        public void DrawOnGraphics(Graphics graphics)
        {
            DrawOnGraphics(graphics, Color.Black);
        }

        public void DrawOnGraphics(Graphics graphics, Color color)
        {
            if (Fill)
            {
                graphics.FillRectangle(new SolidBrush(color), TopLeftCorner.X, TopLeftCorner.Y, Width, Height);
            }
            else
            {
                graphics.DrawRectangle(new Pen(color), TopLeftCorner.X, TopLeftCorner.Y, Width, Height);
            }
        }
    }
}
