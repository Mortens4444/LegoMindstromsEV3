namespace Mindstorms.Core.Enums
{
    public enum UltrasonicSensorMode : byte
	{
		Cm = UARTMode.Mode0,

		Inch = UARTMode.Mode1,

		Listen = UARTMode.Mode2,

		SI_Cm = UARTMode.Mode3,

		SI_Inch = UARTMode.Mode4,

		DC_Cm = UARTMode.Mode5,

		DC_Inch = UARTMode.Mode6
	};
}
