namespace Mindstorms.Core.Enums
{
    public class DaisyChainLayer : EnumLikeObject<DaisyChainLayer>
	{
		/// <summary>
		/// The EV3
		/// </summary>
		public static readonly DaisyChainLayer EV3 = new DaisyChainLayer(0x00, nameof(EV3));

		/// <summary>
		/// First EV3 in the Daisychain
		/// </summary>
		public static readonly DaisyChainLayer First = new DaisyChainLayer(0x01, nameof(First));

		/// <summary>
		/// Second EV3 in the Daisychain
		/// </summary>
		public static readonly DaisyChainLayer Second = new DaisyChainLayer(0x02, nameof(Second));

		/// <summary>
		/// Third EV3 in the Daisychain
		/// </summary>
		public static readonly DaisyChainLayer Third = new DaisyChainLayer(0x03, nameof(Third));

		private DaisyChainLayer(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator DaisyChainLayer(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(DaisyChainLayer value)
		{
			return value.Value;
		}
	}
}
