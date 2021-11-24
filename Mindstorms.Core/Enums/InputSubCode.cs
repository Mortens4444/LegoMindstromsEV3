namespace Mindstorms.Core.Enums
{
    public enum InputSubCode : sbyte
	{
		GetFormat = 0x02,
		CalMinMax = 0x03,
		CalDefault = 0x04,
		GetTypeMode = 0x05,
		GetSymbol = 0x06,
		CalMin = 0x07,
		CalMax = 0x08,
		Setup = 0x09,
		ClearAll = 0x0A,
		GetRaw = 0x0B,
		GetConnection = 0x0C,
		StopAll = 0x0D,
		GetName = 0x15,
		GetModeName = 0x16,
		SetRaw = 0x17,
		GetFigures = 0x18,
		GetChanges = 0x19,
		ClrChanges = 0x1A,
		ReadyPCT = 0x1B,
		ReadyRaw = 0x1C,
		ReadySI = 0x1D,
		GetMinMax = 0x1E,
		GetBumps = 0x1F
	}
}
