namespace Mindstorms.Core.Enums
{
    public class TouchSensorMode : EnumLikeObject<TouchSensorMode>
	{
		public static readonly TouchSensorMode Touch = new TouchSensorMode(UARTMode.Mode0, nameof(Touch));
		public static readonly TouchSensorMode Bump = new TouchSensorMode(UARTMode.Mode1, nameof(Bump));

		private TouchSensorMode(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator TouchSensorMode(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(TouchSensorMode value)
		{
			return value.Value;
		}
	};
}
