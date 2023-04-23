namespace Mindstorms.Core.Enums;

public class LCDColor : EnumLikeObject<LCDColor>
{
	public static readonly LCDColor White = new(0x00, nameof(White));
	public static readonly LCDColor Black = new(0x01, nameof(Black));

	private LCDColor(byte value, string name) : base(value, name)
	{
		Values.Add(value, this);
	}

	public static implicit operator LCDColor(byte value)
	{
		return Values[value];
	}

	public static implicit operator byte(LCDColor value)
	{
		return value.Value;
	}
}
