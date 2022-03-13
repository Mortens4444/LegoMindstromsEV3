namespace Mindstorms.Core.Enums
{
    public class SensorType : EnumLikeObject<SensorType>
	{
		public static readonly SensorType Unknown = new SensorType(0x00, nameof(Unknown));
		public static readonly SensorType NXTTouch = new SensorType(0x01, nameof(NXTTouch));
		public static readonly SensorType NXTLight = new SensorType(0x02, nameof(NXTLight));
		public static readonly SensorType NXTSound = new SensorType(0x03, nameof(NXTSound));
		public static readonly SensorType NXTColor = new SensorType(0x04, nameof(NXTColor));
		public static readonly SensorType NXTUltraSonic = new SensorType(0x05, nameof(NXTUltraSonic));
		public static readonly SensorType NXTTemperature = new SensorType(0x06, nameof(NXTTemperature));
		public static readonly SensorType LargeMotor = new SensorType(0x07, nameof(LargeMotor));
		public static readonly SensorType MediumMotor = new SensorType(0x08, nameof(MediumMotor));
		public static readonly SensorType Touch = new SensorType(0x10, nameof(Touch));
		public static readonly SensorType Test = new SensorType(0x15, nameof(Test));
		public static readonly SensorType Color = new SensorType(0x1D, nameof(Color));
		public static readonly SensorType Ultrasonic = new SensorType(0x1E, nameof(Ultrasonic));
		public static readonly SensorType Gyro = new SensorType(0x20, nameof(Gyro));
		public static readonly SensorType IR = new SensorType(0x21, nameof(IR));
		public static readonly SensorType I2C = new SensorType(0x64, nameof(I2C));
		public static readonly SensorType NXTTest = new SensorType(0x65, nameof(NXTTest));
		public static readonly SensorType None = new SensorType(0x7E, nameof(None));

		private SensorType(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator SensorType(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(SensorType value)
		{
			return value.Value;
		}
	};
}
