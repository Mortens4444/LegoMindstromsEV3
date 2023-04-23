namespace Mindstorms.Core.Enums;

public class UltrasonicSensorMode : EnumLikeObject<UltrasonicSensorMode>
{
	public static readonly UltrasonicSensorMode Cm = new(UARTMode.Mode0, nameof(Cm));
	public static readonly UltrasonicSensorMode Inch = new(UARTMode.Mode1, nameof(Inch));
	public static readonly UltrasonicSensorMode Listen = new(UARTMode.Mode2, nameof(Listen));
	public static readonly UltrasonicSensorMode SI_Cm = new(UARTMode.Mode3, nameof(SI_Cm));
	public static readonly UltrasonicSensorMode SI_Inch = new(UARTMode.Mode4, nameof(SI_Inch));
	public static readonly UltrasonicSensorMode DC_Cm = new(UARTMode.Mode5, nameof(DC_Cm));
	public static readonly UltrasonicSensorMode DC_Inch = new(UARTMode.Mode6, nameof(DC_Inch));

	private UltrasonicSensorMode(byte value, string name) : base(value, name)
	{
		Values.Add(value, this);
	}

	public static implicit operator UltrasonicSensorMode(byte value)
	{
		return Values[value];
	}

	public static implicit operator byte(UltrasonicSensorMode value)
	{
		return value.Value;
	}
};
