namespace Mindstorms.Core.Enums
{
	public class Polarity : EnumLikeObject<Polarity>
	{
		public static readonly Polarity Backward = new(0xFF, nameof(Backward));
		public static readonly Polarity Opposite = new(0x00, nameof(Opposite));
		public static readonly Polarity Forward = new(0x01, nameof(Forward));

		private Polarity(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator Polarity(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(Polarity value)
		{
			return value.Value;
		}
	}
}
