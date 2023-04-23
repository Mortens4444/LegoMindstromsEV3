namespace Mindstorms.Core.Enums;

public class UARTMode : EnumLikeObject<UARTMode>
{
	public static readonly UARTMode Mode0 = new(0x00, nameof(Mode0));
	public static readonly UARTMode Mode1 = new(0x01, nameof(Mode1));
	public static readonly UARTMode Mode2 = new(0x02, nameof(Mode2));
	public static readonly UARTMode Mode3 = new(0x03, nameof(Mode3));
	public static readonly UARTMode Mode4 = new(0x04, nameof(Mode4));
	public static readonly UARTMode Mode5 = new(0x05, nameof(Mode5));
	public static readonly UARTMode Mode6 = new(0x06, nameof(Mode6));
	public static readonly UARTMode Mode7 = new(0x07, nameof(Mode7));

	private UARTMode(byte value, string name) : base(value, name)
	{
		Values.Add(value, this);
	}

	public static implicit operator UARTMode(byte value)
	{
		return Values[value];
	}

	public static implicit operator byte(UARTMode value)
	{
		return value.Value;
	}
}
