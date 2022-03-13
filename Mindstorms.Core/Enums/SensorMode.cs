namespace Mindstorms.Core.Enums
{
    public class SensorMode : EnumLikeObject<SensorMode>
	{
		public static readonly SensorMode Mode0 = new SensorMode(0x00, nameof(Mode0));
		public static readonly SensorMode Mode1 = new SensorMode(0x01, nameof(Mode1));
		public static readonly SensorMode Mode2 = new SensorMode(0x02, nameof(Mode2));
		public static readonly SensorMode Mode3 = new SensorMode(0x03, nameof(Mode3));
		public static readonly SensorMode Mode4 = new SensorMode(0x04, nameof(Mode4));
		public static readonly SensorMode Mode5 = new SensorMode(0x05, nameof(Mode5));
		public static readonly SensorMode Mode6 = new SensorMode(0x06, nameof(Mode6));

		private SensorMode(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator SensorMode(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(SensorMode value)
		{
			return value.Value;
		}
	};
}
