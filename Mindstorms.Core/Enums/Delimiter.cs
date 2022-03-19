namespace Mindstorms.Core.Enums
{
    public class Delimiter : EnumLikeObject<Delimiter>
    {
		public static readonly Delimiter None = new Delimiter(0x00, nameof(None));
		public static readonly Delimiter Tab = new Delimiter(0x01, nameof(Tab));
		public static readonly Delimiter Space = new Delimiter(0x02, nameof(Space));
		public static readonly Delimiter CarriageReturn = new Delimiter(0x03, nameof(CarriageReturn));
		public static readonly Delimiter Colon = new Delimiter(0x04, nameof(Colon));
		public static readonly Delimiter Comma = new Delimiter(0x05, nameof(Comma));
		public static readonly Delimiter LineFeed = new Delimiter(0x06, nameof(LineFeed));
		public static readonly Delimiter CRLF = new Delimiter(0x07, nameof(CRLF));

		private Delimiter(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator Delimiter(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(Delimiter value)
		{
			return value.Value;
		}
	}
}
