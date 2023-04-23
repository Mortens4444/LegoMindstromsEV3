namespace Mindstorms.Core.Enums;

public class OutputPort : EnumLikeObject<OutputPort>
{
	public static readonly OutputPort A = new(0x01, nameof(A));
	public static readonly OutputPort B = new(0x02, nameof(B));
	public static readonly OutputPort C = new(0x04, nameof(C));
	public static readonly OutputPort D = new(0x08, nameof(D));

	public static readonly OutputPort AB = new(A | B, nameof(AB));
	public static readonly OutputPort AC = new(A | C, nameof(AC));
	public static readonly OutputPort AD = new(A | D, nameof(AD));
	public static readonly OutputPort BC = new(B | C, nameof(BC));
	public static readonly OutputPort BD = new(B | D, nameof(BD));
	public static readonly OutputPort CD = new(C | D, nameof(CD));

	public static readonly OutputPort ABC = new(A | B | C, nameof(ABC));
	public static readonly OutputPort ABD = new(A | B | D, nameof(ABD));
	public static readonly OutputPort ACD = new(A | C | D, nameof(ACD));
	public static readonly OutputPort BCD = new(B | C | D, nameof(BCD));

	public static readonly OutputPort ABCD = new(A | B | C | D, nameof(ABCD));

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
