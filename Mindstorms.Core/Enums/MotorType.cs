namespace Mindstorms.Core.Enums;

public class MotorType : EnumLikeObject<MotorType>
{
	public static readonly MotorType Large = new(0x07, nameof(Large));
	public static readonly MotorType Medium = new(0x08, nameof(Medium));

	private MotorType(byte value, string name) : base(value, name)
	{
		Values.Add(value, this);
	}

	public static implicit operator MotorType(byte value)
	{
		return Values[value];
	}

	public static implicit operator byte(MotorType value)
	{
		return value.Value;
	}
}
