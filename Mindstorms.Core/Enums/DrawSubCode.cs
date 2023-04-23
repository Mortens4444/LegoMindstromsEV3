namespace Mindstorms.Core.Enums;

public class DrawSubCode : EnumLikeObject<DrawSubCode>
{
    public static readonly DrawSubCode Update = new(0x00, nameof(Update));
    public static readonly DrawSubCode Clean = new(0x01, nameof(Clean));
    public static readonly DrawSubCode Pixel = new(0x02, nameof(Pixel));
    public static readonly DrawSubCode Line = new(0x03, nameof(Line));
    public static readonly DrawSubCode Circle = new(0x04, nameof(Circle));
    public static readonly DrawSubCode Text = new(0x05, nameof(Text));
    public static readonly DrawSubCode FillRectangle = new(0x09, nameof(FillRectangle));
    public static readonly DrawSubCode Rectangle = new(0x0A, nameof(Rectangle));
    public static readonly DrawSubCode InverseRectangle = new(0x10, nameof(InverseRectangle));
    public static readonly DrawSubCode SelectFont = new(0x11, nameof(SelectFont));
    public static readonly DrawSubCode TopLine = new(0x12, nameof(TopLine));
    public static readonly DrawSubCode FillWindow = new(0x13, nameof(FillWindow));
    public static readonly DrawSubCode FillCircle = new(0x18, nameof(FillCircle));
    public static readonly DrawSubCode Restore = new(0x1A, nameof(Restore));
    public static readonly DrawSubCode BmpFile = new(0x1C, nameof(BmpFile));
    public static readonly DrawSubCode GraphDraw = new(0x1F, nameof(GraphDraw));

    private DrawSubCode(byte value, string name) : base(value, name)
    {
        Values.Add(value, this);
    }

    public static implicit operator DrawSubCode(byte value)
    {
        return Values[value];
    }

    public static implicit operator byte(DrawSubCode value)
    {
        return value.Value;
    }
}
