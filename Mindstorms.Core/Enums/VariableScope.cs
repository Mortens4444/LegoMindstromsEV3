namespace Mindstorms.Core.Enums
{
	public class VariableScope : EnumLikeObject<VariableScope>
	{
		public static readonly VariableScope Local = new VariableScope(0x00, nameof(Local));
		public static readonly VariableScope Global = new VariableScope(0x20, nameof(Global));

		private VariableScope(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator VariableScope(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(VariableScope value)
		{
			return value.Value;
		}

		public static byte operator |(byte value, VariableScope variableScope) => (byte)(value | variableScope.Value);

	}
}
