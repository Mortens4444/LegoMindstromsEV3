namespace Mindstorms.Core.Enums;

    public class CommunicationInterface : EnumLikeObject<CommunicationInterface>
    {
	public static readonly CommunicationInterface USB = new(0x01, nameof(USB));
	public static readonly CommunicationInterface Bluetooth = new(0x02, nameof(Bluetooth));
	public static readonly CommunicationInterface WiFi = new(0x03, nameof(WiFi));

	private CommunicationInterface(byte value, string name) : base(value, name)
	{
		Values.Add(value, this);
	}

	public static implicit operator CommunicationInterface(byte value)
	{
		return Values[value];
	}

	public static implicit operator byte(CommunicationInterface value)
	{
		return value.Value;
	}
}
