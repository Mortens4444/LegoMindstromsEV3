using System.Drawing;

namespace Mindstorms.Core.Drawing;

public class EV3Line : IEV3DrawingElement
{
    public byte X1 { get; }

    public byte Y1 { get; }

    public byte X2 { get; }

    public byte Y2 { get; }

    public EV3Line(byte x1, byte y1, byte x2, byte y2)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    public void DrawOnGraphics(Graphics graphics)
    {
        DrawOnGraphics(graphics, Color.Black);
    }

    public void DrawOnGraphics(Graphics graphics, Color color)
    {
        graphics.DrawLine(new Pen(color), X1, Y1, X2, Y2);
    }
}
