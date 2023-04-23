using System.Drawing;

namespace Mindstorms.Core.Drawing;

public class EV3Circle : IEV3DrawingElement
{
    public EV3Point Center { get; private set; } = new EV3Point(0, 0);

    public byte Radius { get; private set; }

    public bool Fill { get; private set; }

    public EV3Circle(byte x, byte y, byte radius, bool fill)
    {
        Initialize(x, y, radius, fill);
    }

    public EV3Circle(byte x1, byte y1, byte x2, byte y2, bool fill)
    {
        var dx = Math.Abs(x1 - x2) / 2;
        var dy = Math.Abs(y1 - y2) / 2;
        var radius = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        var x = (byte)(Math.Min(x1, x2) + dx);
        var y = (byte)(Math.Min(y1, y2) + dy);
        Initialize(x, y, (byte)radius, fill);
    }

    public void IncrementRadius(byte delta)
    {
        Radius += delta;
    }

    public void DrawOnGraphics(Graphics graphics)
    {
        DrawOnGraphics(graphics, Color.Black);
    }

    public void DrawOnGraphics(Graphics graphics, Color color)
    {
        var diameter = 2 * Radius;
        if (Fill)
        {
            graphics.FillEllipse(new SolidBrush(color), Center.X - Radius, Center.Y - Radius, diameter, diameter);
        }
        else
        {
            graphics.DrawEllipse(new Pen(color), Center.X - Radius, Center.Y - Radius, diameter, diameter);
        }
    }

    public EV3Circle? GetCollidingCircle(IEnumerable<EV3Circle> circles)
    {
        foreach (var circle in circles)
        {
            if (IsColliding(circle))
            {
                return circle;
            }
        }

        return null;
    }

    public bool IsColliding(EV3Circle circle)
    {
        if (!Equals(circle) && (Center.GetDistance(circle.Center) < Radius + circle.Radius))
        {
            return true;
        }

        return false;
    }

    private void Initialize(byte x, byte y, byte radius, bool fill)
    {
        Center = new EV3Point(x, y);
        Radius = radius;
        Fill = fill;
    }
}
