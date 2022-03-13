namespace Mindstorms.Core.Enums
{
    public class InfraredSensorMode : EnumLikeObject<InfraredSensorMode>
    {
        /// <summary>
        /// Distance is represented by a number between 0 (very close) and 100 (very far - which is about 70 cm).
        /// </summary>
        public static readonly InfraredSensorMode ProximityMode = new InfraredSensorMode(0x00, nameof(ProximityMode));

        /// <summary>
        /// Distance is represented by a number between 0 (very close) and 100 (very far - which is about 200 cm).
        /// The direction is between -25 and 25, where 0 zero means that the infrared beacon is in the front of the sensor.
        /// </summary>
        public static readonly InfraredSensorMode InfraredSeekerMode = new InfraredSensorMode(0x01, nameof(InfraredSeekerMode));

        public static readonly InfraredSensorMode InfraredRemoteMode = new InfraredSensorMode(0x02, nameof(InfraredRemoteMode));

        private InfraredSensorMode(byte value, string name) : base(value, name)
        {
            Values.Add(value, this);
        }

        public static implicit operator InfraredSensorMode(byte value)
        {
            return Values[value];
        }

        public static implicit operator byte(InfraredSensorMode value)
        {
            return value.Value;
        }
    }
}
