namespace Mindstorms.Core.Enums
{
    public enum LightSensorMode : byte
	{
		/// <summary>
		/// The output from the sensor within light sensor mode is a value between 0 – 100 where 0 equal no reflected light measured and 100 equals full light reflection.
		/// </summary>
		MeasuringReflectedLight = UARTMode.Mode0,

		/// <summary>
		/// The output from the sensor within ambient sensor mode is a value between 0 – 100 where 0 equal darkness while 100 equals directly pointing towards sun-light.
		/// </summary>
		MeasuringAmbientLight = UARTMode.Mode1,

		/// <summary>
		/// The sensor is able to determine between 7 different colors.
		/// </summary>
		MeasuringColors = UARTMode.Mode2,

		MeasuringReflectedLightRaw = UARTMode.Mode3,

		RGBRaw = UARTMode.Mode4,

		Calibration = UARTMode.Mode5

	};
}
