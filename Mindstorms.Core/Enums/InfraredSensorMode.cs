namespace Mindstorms.Core.Enums
{
    public enum InfraredSensorMode
    {
        /// <summary>
        /// Distanbce is represented by a number between 0 (very close) and 100 (very far - which is about 70 cm).
        /// </summary>
        ProximityMode,

        /// <summary>
        /// Distanbce is represented by a number between 0 (very close) and 100 (very far - which is about 200 cm).
        /// The direction is between -25 and 25, where 0 zero means that the infrared beacon is in the front of the sensor.
        /// </summary>
        InfraredSeekerMode,

        InfraredRemoteMode,
    }
}
