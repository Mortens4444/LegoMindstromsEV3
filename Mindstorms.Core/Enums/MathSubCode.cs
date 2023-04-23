namespace Mindstorms.Core.Enums;

public class MathSubCode : EnumLikeObject<MathSubCode>
{
    public static readonly MathSubCode Exp = new(0x01, nameof(Exp));
    public static readonly MathSubCode Mod = new(0x02, nameof(Mod));
    public static readonly MathSubCode Floor = new(0x03, nameof(Floor));
    public static readonly MathSubCode Ceil = new(0x04, nameof(Ceil));
    public static readonly MathSubCode Round = new(0x05, nameof(Round));
    public static readonly MathSubCode Abs = new(0x06, nameof(Abs));
    public static readonly MathSubCode Negate = new(0x07, nameof(Negate));
    public static readonly MathSubCode Sqrt = new(0x08, nameof(Sqrt));
    public static readonly MathSubCode Log = new(0x09, nameof(Log));
    public static readonly MathSubCode Ln = new(0x0A, nameof(Ln));
    public static readonly MathSubCode Sin = new(0x0B, nameof(Sin));
    public static readonly MathSubCode Cos = new(0x0C, nameof(Cos));
    public static readonly MathSubCode Tan = new(0x0D, nameof(Tan));
    public static readonly MathSubCode ASin = new(0x0E, nameof(ASin));
    public static readonly MathSubCode ACos = new(0x0F, nameof(ACos));
    public static readonly MathSubCode ATan = new(0x10, nameof(ATan));
    public static readonly MathSubCode Mod8 = new(0x11, nameof(Mod8));
    public static readonly MathSubCode Mod16 = new(0x12, nameof(Mod16));
    public static readonly MathSubCode Mod32 = new(0x13, nameof(Mod32));
    public static readonly MathSubCode Pow = new(0x14, nameof(Pow));
    public static readonly MathSubCode Trunc = new(0x15, nameof(Trunc));

    private MathSubCode(byte value, string name) : base(value, name)
    {
        Values.Add(value, this);
    }

    public static implicit operator MathSubCode(byte value)
    {
        return Values[value];
    }

    public static implicit operator byte(MathSubCode value)
    {
        return value.Value;
    }
}
