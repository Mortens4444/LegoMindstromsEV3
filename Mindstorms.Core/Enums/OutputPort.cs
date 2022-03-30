using System;

namespace Mindstorms.Core.Enums
{
	public class OutputPort : EnumLikeObject<OutputPort>
	{
		public static readonly OutputPort A = new OutputPort(0x01, nameof(A));
		public static readonly OutputPort B = new OutputPort(0x02, nameof(B));
		public static readonly OutputPort C = new OutputPort(0x04, nameof(C));
		public static readonly OutputPort D = new OutputPort(0x08, nameof(D));

		public static readonly OutputPort AB = new OutputPort(A | B, nameof(AB));
		public static readonly OutputPort AC = new OutputPort(A | C, nameof(AC));
		public static readonly OutputPort AD = new OutputPort(A | D, nameof(AD));
		public static readonly OutputPort BC = new OutputPort(B | C, nameof(BC));
		public static readonly OutputPort BD = new OutputPort(B | D, nameof(BD));
		public static readonly OutputPort CD = new OutputPort(C | D, nameof(CD));

		public static readonly OutputPort ABC = new OutputPort(A | B | C, nameof(ABC));
		public static readonly OutputPort ABD = new OutputPort(A | B | D, nameof(ABD));
		public static readonly OutputPort ACD = new OutputPort(A | C | D, nameof(ACD));
		public static readonly OutputPort BCD = new OutputPort(B | C | D, nameof(BCD));

		public static readonly OutputPort ABCD = new OutputPort(A | B | C | D, nameof(ABCD));

		private OutputPort(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public int GetIndex()
		{
			return (int)Math.Log(Value, 2);
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
