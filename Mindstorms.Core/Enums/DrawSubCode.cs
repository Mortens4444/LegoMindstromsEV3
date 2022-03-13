namespace Mindstorms.Core.Enums
{
    public class DrawSubCode : EnumLikeObject<DrawSubCode>
    {
        public static readonly DrawSubCode Update = new DrawSubCode(0x00, nameof(Update));
        public static readonly DrawSubCode Clean = new DrawSubCode(0x01, nameof(Clean));
        public static readonly DrawSubCode Pixel = new DrawSubCode(0x02, nameof(Pixel));
        public static readonly DrawSubCode Line = new DrawSubCode(0x03, nameof(Line));
        public static readonly DrawSubCode Circle = new DrawSubCode(0x04, nameof(Circle));
        public static readonly DrawSubCode Text = new DrawSubCode(0x05, nameof(Text));
        public static readonly DrawSubCode FillRectangle = new DrawSubCode(0x09, nameof(FillRectangle));
        public static readonly DrawSubCode Rectangle = new DrawSubCode(0x0A, nameof(Rectangle));
        public static readonly DrawSubCode InverseRectangle = new DrawSubCode(0x10, nameof(InverseRectangle));
        public static readonly DrawSubCode SelectFont = new DrawSubCode(0x11, nameof(SelectFont));
        public static readonly DrawSubCode TopLine = new DrawSubCode(0x12, nameof(TopLine));
        public static readonly DrawSubCode FillWindow = new DrawSubCode(0x13, nameof(FillWindow));
        public static readonly DrawSubCode FillCircle = new DrawSubCode(0x18, nameof(FillCircle));
        public static readonly DrawSubCode Restore = new DrawSubCode(0x1A, nameof(Restore));
        public static readonly DrawSubCode BmpFile = new DrawSubCode(0x1C, nameof(BmpFile));
        public static readonly DrawSubCode GraphDraw = new DrawSubCode(0x1F, nameof(GraphDraw));

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
}
