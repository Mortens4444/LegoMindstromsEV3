namespace Mindstorms.Core.Enums;

public class BreakType : EnumLikeObject<BreakType>
{
	public static readonly BreakType Float = new(0x00, nameof(Float));
    public static readonly BreakType Break = new(0x01, nameof(Break));

	private BreakType(byte value, string name) : base(value, name)
	{
		Values.Add(value, this);
	}

	public static implicit operator BreakType(byte value)
	{
		return Values[value];
	}

	public static implicit operator byte(BreakType value)
	{
		return value.Value;
	}
}
