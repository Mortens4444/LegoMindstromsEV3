using Mindstorms.Core.Enums;
using System.Drawing;

namespace Mindstorms.Core.Drawing
{
    public class EV3Text : IEV3DrawingElement
    {
        public byte X { get; }

        public byte Y { get; }

        public string Text { get; }

        public FontType FontType { get; }

        public EV3Text(EV3Point point, string text, FontType fontType = FontType.Small)
            : this(point.X, point.Y, text, fontType)
        { }

        public EV3Text(byte x, byte y, string text, FontType fontType = FontType.Small)
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
            var fontSize = FontType == FontType.Tiny ? 8 : FontType == FontType.Small ? 12 : 16;
            graphics.DrawString(Text, new Font(FontFamily.GenericSerif, fontSize), new SolidBrush(color), X, Y);
        }
    }
}
