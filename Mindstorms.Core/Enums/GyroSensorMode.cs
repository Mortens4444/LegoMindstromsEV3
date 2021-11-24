namespace Mindstorms.Core.Enums
{
    public enum GyroSensorMode : byte
	{
		Angle = UARTMode.Mode0,

		Rate = UARTMode.Mode1,

		Fast = UARTMode.Mode2,

		RateAndAngle = UARTMode.Mode3,

		Calibration = UARTMode.Mode4
	};
}
