using System.Drawing;

namespace Mindstorms.Core.Drawing
{
    public interface IEV3DrawingElement
    {
        void DrawOnGraphics(Graphics graphics);

        void DrawOnGraphics(Graphics graphics, Color color);
    }
}
