namespace Mindstorms.Core.Enums
{
    public class PlayType : EnumLikeObject<PlayType>
    {
		public static readonly PlayType WaitForCompletion = new PlayType(0x00, nameof(WaitForCompletion));
		public static readonly PlayType PlayOnce = new PlayType(0x01, nameof(PlayOnce));
		public static readonly PlayType Repeat = new PlayType(0x02, nameof(Repeat));

		private PlayType(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator PlayType(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(PlayType value)
		{
			return value.Value;
		}
	}
}
