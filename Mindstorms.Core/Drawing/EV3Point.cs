using System;
using System.Drawing;

namespace Mindstorms.Core.Drawing
{
    public class EV3Point : IEV3DrawingElement
    {
        public byte X { get; set; }

        public byte Y { get; set; }

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

        public double GetDistance(EV3Point eV3Point)
        {
            return Math.Sqrt(Math.Pow(X - eV3Point.X, 2) + Math.Pow(Y - eV3Point.Y, 2));
        }
    }
}
