namespace Mindstorms.Core.Enums
{
    public class SensorPort : EnumLikeObject<SensorPort>
	{
        /// <summary>
        /// 460 Kbit/s
        /// </summary>
        public static readonly SensorPort In1 = new SensorPort(0x00, nameof(In1));

        /// <summary>
        /// 460 Kbit/s
        /// </summary>
		public static readonly SensorPort In2 = new SensorPort(0x01, nameof(In2));

        /// <summary>
        /// 230 Kbit/s
        /// </summary>
		public static readonly SensorPort In3 = new SensorPort(0x02, nameof(In3));

        /// <summary>
        /// 230 Kbit/s
        /// </summary>
		public static readonly SensorPort In4 = new SensorPort(0x03, nameof(In4));

		private SensorPort(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator SensorPort(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(SensorPort value)
		{
			return value.Value;
		}
	};
}
