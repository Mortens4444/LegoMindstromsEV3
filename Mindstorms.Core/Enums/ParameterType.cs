namespace Mindstorms.Core.Enums
{
    /// <summary>
    /// Encoded Parameter type
    /// </summary>
	public class ParameterType : EnumLikeObject<ParameterType>
	{
		public static readonly ParameterType Constant = new ParameterType(0x00, nameof(Constant));
		public static readonly ParameterType Variable = new ParameterType(0x40, nameof(Variable));

		private ParameterType(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator ParameterType(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(ParameterType value)
		{
			return value.Value;
		}

		public static byte operator |(byte value, ParameterType parameterType) => (byte)(value | parameterType.Value);

		public static byte operator |(ParameterType parameterType, VariableScope variableScope) => (byte)(parameterType.Value | variableScope.Value);
	}
}
