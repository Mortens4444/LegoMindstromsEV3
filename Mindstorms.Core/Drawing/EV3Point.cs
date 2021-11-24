using System.Drawing;

namespace Mindstorms.Core.Drawing
{
    public class EV3Point : IEV3DrawingElement
    {
        public byte X { get; }

        public byte Y { get; }

        public EV3Point(byte x, byte y)
        {
            X = x;
            Y = y;
        }

        public void DrawOnGraphics(Graphics graphics)
        {
            DrawOnGraphics(graphics, Color.Black);
        }

        public void DrawOnGraphics(Graphics graphics, Color color)
        {
            graphics.FillRectangle(new SolidBrush(color), X, Y, 1, 1);
        }
    }
}
