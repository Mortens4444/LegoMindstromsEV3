namespace Mindstorms.Core.Enums
{
    public class InputSubCode : EnumLikeObject<InputSubCode>
	{
        public const byte ReadyPCTValue = 0x1B;
        public const byte ReadyRawValue = 0x1C;
        public const byte ReadySIValue = 0x1D;

        public static readonly InputSubCode GetFormat = new InputSubCode(0x02, nameof(GetFormat));
		public static readonly InputSubCode CalMinMax = new InputSubCode(0x03, nameof(CalMinMax));
		public static readonly InputSubCode CalDefault = new InputSubCode(0x04, nameof(CalDefault));
		public static readonly InputSubCode GetTypeMode = new InputSubCode(0x05, nameof(GetTypeMode));
		public static readonly InputSubCode GetSymbol = new InputSubCode(0x06, nameof(GetSymbol));
		public static readonly InputSubCode CalMin = new InputSubCode(0x07, nameof(CalMin));
		public static readonly InputSubCode CalMax = new InputSubCode(0x08, nameof(CalMax));
		public static readonly InputSubCode Setup = new InputSubCode(0x09, nameof(Setup));
		public static readonly InputSubCode ClearAll = new InputSubCode(0x0A, nameof(ClearAll));
		public static readonly InputSubCode GetRaw = new InputSubCode(0x0B, nameof(GetRaw));
		public static readonly InputSubCode GetConnection = new InputSubCode(0x0C, nameof(GetConnection));
		public static readonly InputSubCode StopAll = new InputSubCode(0x0D, nameof(StopAll));
		public static readonly InputSubCode GetName = new InputSubCode(0x15, nameof(GetName));
		public static readonly InputSubCode GetModeName = new InputSubCode(0x16, nameof(GetModeName));
		public static readonly InputSubCode SetRaw = new InputSubCode(0x17, nameof(SetRaw));
		public static readonly InputSubCode GetFigures = new InputSubCode(0x18, nameof(GetFigures));
		public static readonly InputSubCode GetChanges = new InputSubCode(0x19, nameof(GetChanges));
		public static readonly InputSubCode ClrChanges = new InputSubCode(0x1A, nameof(ClrChanges));
		public static readonly InputSubCode ReadyPCT = new InputSubCode(ReadyPCTValue, nameof(ReadyPCT));
		public static readonly InputSubCode ReadyRaw = new InputSubCode(ReadyRawValue, nameof(ReadyRaw));
		public static readonly InputSubCode ReadySI = new InputSubCode(ReadySIValue, nameof(ReadySI));
		public static readonly InputSubCode GetMinMax = new InputSubCode(0x1E, nameof(GetMinMax));
		public static readonly InputSubCode GetBumps = new InputSubCode(0x1F, nameof(GetBumps));

		private InputSubCode(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator InputSubCode(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(InputSubCode value)
		{
			return value.Value;
		}
	}
}
