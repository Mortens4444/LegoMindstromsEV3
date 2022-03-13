namespace Mindstorms.Core.Enums
{
    public class LightSensorMode : EnumLikeObject<LightSensorMode>
	{
        /// <summary>
        /// The output from the sensor within light sensor mode is a value between 0 – 100 where 0 equal no reflected light measured and 100 equals full light reflection.
        /// </summary>
        public static readonly LightSensorMode MeasuringReflectedLight = new LightSensorMode(UARTMode.Mode0, nameof(MeasuringReflectedLight));

		/// <summary>
		/// The output from the sensor within ambient sensor mode is a value between 0 – 100 where 0 equal darkness while 100 equals directly pointing towards sun-light.
		/// </summary>
		public static readonly LightSensorMode MeasuringAmbientLight = new LightSensorMode(UARTMode.Mode1, nameof(MeasuringAmbientLight));

		/// <summary>
		/// The sensor is able to determine between 7 different colors.
		/// </summary>
		public static readonly LightSensorMode MeasuringColors = new LightSensorMode(UARTMode.Mode2, nameof(MeasuringColors));

		public static readonly LightSensorMode MeasuringReflectedLightRaw = new LightSensorMode(UARTMode.Mode3, nameof(MeasuringReflectedLightRaw));
		public static readonly LightSensorMode RGBRaw = new LightSensorMode(UARTMode.Mode4, nameof(RGBRaw));
		public static readonly LightSensorMode Calibration = new LightSensorMode(UARTMode.Mode5, nameof(Calibration));

		private LightSensorMode(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator LightSensorMode(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(LightSensorMode value)
		{
			return value.Value;
		}
	};
}
