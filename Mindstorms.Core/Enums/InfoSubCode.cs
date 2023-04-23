namespace Mindstorms.Core.Enums;

public class InfoSubCode : EnumLikeObject<InfoSubCode>
{
    public static readonly InfoSubCode SetError = new(0x01, nameof(SetError));
    public static readonly InfoSubCode GetError = new(0x02, nameof(GetError));
    public static readonly InfoSubCode GetErrorText = new(0x03, nameof(GetErrorText));
    public static readonly InfoSubCode GetVolume = new(0x04, nameof(GetVolume));
    public static readonly InfoSubCode SetVolume = new(0x05, nameof(SetVolume));
    public static readonly InfoSubCode GetMinutes = new(0x06, nameof(GetMinutes));
    public static readonly InfoSubCode SetMinutes = new(0x07, nameof(SetMinutes));

    private InfoSubCode(byte value, string name) : base(value, name)
    {
        Values.Add(value, this);
    }

    public static implicit operator InfoSubCode(byte value)
    {
        return Values[value];
    }

    public static implicit operator byte(InfoSubCode value)
    {
        return value.Value;
    }
}
