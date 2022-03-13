namespace Mindstorms.Core.Enums
{
    public class ParameterFormat : EnumLikeObject<ParameterFormat>
    {
    	public static readonly ParameterFormat Short = new ParameterFormat(0x00, nameof(Short));
    	public static readonly ParameterFormat Long = new ParameterFormat(0x80, nameof(Long));

		private ParameterFormat(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator ParameterFormat(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(ParameterFormat value)
		{
			return value.Value;
		}

		public static byte operator |(ParameterFormat parameterFormat, FollowType followType) => (byte)(parameterFormat.Value | followType.Value);
	}
}
