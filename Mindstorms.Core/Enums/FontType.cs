namespace Mindstorms.Core.Enums;

public class FontType : EnumLikeObject<FontType>
{
	public static readonly FontType Tiny = new(0x03, nameof(Tiny));
	public static readonly FontType Normal = new(0x01, nameof(Normal));
	public static readonly FontType Big = new(0x02, nameof(Big));

	private FontType(byte value, string name) : base(value, name)
	{
		Values.Add(value, this);
	}

	public static implicit operator FontType(byte value)
	{
		return Values[value];
	}

	public static implicit operator byte(FontType value)
	{
		return value.Value;
	}
}
