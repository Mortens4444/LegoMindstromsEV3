using Mindstorms.Core.Enums;
using System;
using System.Drawing;

namespace Mindstorms.Core.Drawing
{
    public class EV3Text : IEV3DrawingElement
    {
        public byte X { get; }

        public byte Y { get; }

        public string Text { get; }

        public FontType FontType { get; }

        public EV3Text(EV3Point point, string text, FontType fontType = FontType.Normal)
            : this(point.X, point.Y, text, fontType)
        { }

        public EV3Text(byte x, byte y, string text, FontType fontType = FontType.Normal)
        {
            X = x;
            Y = y;
            Text = text;
            FontType = fontType;
        }

        public void DrawOnGraphics(Graphics graphics)
        {
            DrawOnGraphics(graphics, System.Drawing.Color.Black);
        }

        public void DrawOnGraphics(Graphics graphics, System.Drawing.Color color)
        {
            var fontSize = (float)(Math.Pow(2, (int)FontType) * 5);
            graphics.DrawString(Text, new Font(FontFamily.GenericSerif, fontSize), new SolidBrush(color), X, Y);
        }
    }
}
