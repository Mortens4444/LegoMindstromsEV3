namespace Mindstorms.Core.Enums
{
	public class OutputPort : EnumLikeObject<OutputPort>
	{
		public static readonly OutputPort A = new OutputPort(0x01, nameof(A));
		public static readonly OutputPort B = new OutputPort(0x02, nameof(B));
		public static readonly OutputPort C = new OutputPort(0x04, nameof(C));
		public static readonly OutputPort D = new OutputPort(0x08, nameof(D));

		private OutputPort(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator OutputPort(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(OutputPort value)
		{
			return value.Value;
		}

        public static byte operator |(OutputPort outputPort1, OutputPort outputPort2) => (byte)(outputPort1.Value | outputPort2.Value);
    };
}
