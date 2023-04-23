namespace Mindstorms.Core.Enums;

public class State : EnumLikeObject<State>
{
	public static readonly State Disable = new(0x00, nameof(Disable));
	public static readonly State Enable = new(0x01, nameof(Enable));

	private State(byte value, string name) : base(value, name)
	{
		Values.Add(value, this);
	}

	public static implicit operator State(byte value)
	{
		return Values[value];
	}

	public static implicit operator byte(State value)
	{
		return value.Value;
	}
}
