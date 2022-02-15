namespace Mindstorms.Core.Enums
{
    public enum DrawSubCode : sbyte
    {
        Update = 0,
        Clean = 1,
		Pixel = 2,
        Line = 3,
        Circle = 4,
        Text = 5,

        FillRectangle = 9,
        Rectangle = 10,

        InverseRectangle = 16,
        SelectFont = 17,
        TopLine = 18,
        
        FillCircle = 24,
        Restore = 0x1A,
        BmpFile = 0x1C,
        GraphDraw = 0x1F
    }
}
