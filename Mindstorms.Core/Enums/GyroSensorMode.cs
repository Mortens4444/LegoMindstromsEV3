namespace Mindstorms.Core.Enums
{
    public class GyroSensorMode : EnumLikeObject<GyroSensorMode>
	{
		public static readonly GyroSensorMode Angle = new GyroSensorMode(UARTMode.Mode0, nameof(Angle));
		public static readonly GyroSensorMode Rate = new GyroSensorMode(UARTMode.Mode1, nameof(Rate));
		public static readonly GyroSensorMode Fast = new GyroSensorMode(UARTMode.Mode2, nameof(Fast));
		public static readonly GyroSensorMode RateAndAngle = new GyroSensorMode(UARTMode.Mode3, nameof(RateAndAngle));
		public static readonly GyroSensorMode Calibration = new GyroSensorMode(UARTMode.Mode4, nameof(Calibration));

		private GyroSensorMode(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator GyroSensorMode(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(GyroSensorMode value)
		{
			return value.Value;
		}
	};
}
