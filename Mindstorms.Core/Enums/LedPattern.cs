namespace Mindstorms.Core.Enums;

public class LedPattern : EnumLikeObject<LedPattern>
{
    public static readonly LedPattern Off = new(0x00, nameof(Off));
    public static readonly LedPattern Green = new(0x01, nameof(Green));
    public static readonly LedPattern Red = new(0x02, nameof(Red));
    public static readonly LedPattern Orange = new(0x3, nameof(Orange));
    public static readonly LedPattern GreenFlashing = new(0x04, nameof(GreenFlashing));
    public static readonly LedPattern RedFlashing = new(0x05, nameof(RedFlashing));
    public static readonly LedPattern OrangeFlashing = new(0x06, nameof(OrangeFlashing));
    public static readonly LedPattern GreenPulse = new(0x07, nameof(GreenPulse));
    public static readonly LedPattern RedPulse = new(0x08, nameof(RedPulse));
    public static readonly LedPattern OrangePulse = new(0x09, nameof(OrangePulse));

    private LedPattern(byte value, string name) : base(value, name)
    {
        Values.Add(value, this);
    }

    public static implicit operator LedPattern(byte value)
    {
        return Values[value];
    }

    public static implicit operator byte(LedPattern value)
    {
        return value.Value;
    }
}
