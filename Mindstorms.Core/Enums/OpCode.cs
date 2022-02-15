namespace Mindstorms.Core.Enums
{
    public enum OpCode : byte
	{
		Error = 0x00,
		Nop = 0x01,

		// VM
		ProgramStop = 0x02,
		ProgramStart = 0x03,

		ObjectStop = 0x04,
		ObjectStart = 0x05,
		ObjectTrigger = 0x06,
		ObjectWait = 0x07,

		Return = 0x08,
		Call = 0x09,
		ObjectEnd = 0x0A,
		Sleep = 0x0B,

		ProgramInfo = 0x0C,

		Label = 0x0D,
		Probe = 0x0E,
		Do = 0x0F,

		Add8 = 0x10,
		Add16 = 0x11,
		Add32 = 0x12,
		AddFloat = 0x13,

		Sub8 = 0x14,
		Sub16 = 0x15,
		Sub32 = 0x16,
		SubFloat = 0x17,

		Mul8 = 0x18,
		Mul16 = 0x19,
		Mul32 = 0x1A,
		MulFloat = 0x1B,

		Div8 = 0x1C,
		Div16 = 0x1D,
		Div32 = 0x1E,
		DivFloat = 0x1F,

		Or8 = 0x20,
		Or16 = 0x21,
		Or32 = 0x22,

		And8 = 0x24,
		And16 = 0x25,
		And32 = 0x26,

		Xor8 = 0x28,
		Xor16 = 0x29,
		Xor32 = 0x2A,

		Rotate8 = 0x2C,
		Rotate16 = 0x2D,
		Rotate32 = 0x2E,

		// Move
		InitBytes = 0x2F,

		Move8_8 = 0x30,
		Move8_16 = 0x31,
		Move8_32 = 0x32,
		Move8_F = 0x33,

		Move16_8 = 0x34,
		Move16_16 = 0x35,
		Move16_32 = 0x36,
		Move16_F = 0x37,

		Move32_8 = 0x38,
		Move32_16 = 0x39,
		Move32_32 = 0x3A,
		Move32_F = 0x3B,

		MoveF_8 = 0x3C,
		MoveF_16 = 0x3D,
		MoveF_32 = 0x3E,
		MoveF_F = 0x3F,

		System = 0x60,
		PortConvOutput = 0x61,
		PortConvInput = 0x62,
		NoteToFrequency = 0x63,

		// VM
		Info = 0x7C,
		String = 0x7D,
		MemoryWrite = 0x7E,
		MemoryRead = 0x7F,

		// UI
		UIRead = 0x81,
		UIWrite = 0x82,
		Button = 0x83,
		DrawUI = 0x84,
		BP0 = 0x88,
		BP1 = 0x89,
		BP2 = 0x8A,
		BP3 = 0x8B,
		PBSet = 0x8C,
		Math = 0x8D,
		Random = 0x8E,

		KeepAlive = 0x90,

		// Sound
		Sound = 0x94,
		SoundTest = 0x95,
		SoundReady = 0x96,

		// Input
		InputSample = 0x97,
		InputDeviceList = 0x98,
		InputDevice = 0x99,
		InputRead = 0x9A,
		InputTest = 0x9B,
		InputReady = 0x9C,
		InputReadSI = 0x9D,
		InputReadExt = 0x9E,
		InputWrite = 0x9F,

		// Output
		OutputGetType = 0xA0,
		OutputSetType = 0xA1,
		OutputReset = 0xA2,
		OutputStop = 0xA3,
		OutputPower = 0xA4,
		OutputSpeed = 0xA5,
		OutputStart = 0xA6,
		OutputPolarity = 0xA7,
		OutputRead = 0xA8,
		OutputTest = 0xA9,
		OutputReady = 0xAA,
		OutputPosition = 0xAB,
		OutputStepPower = 0xAC,
		OutputTimePower = 0xAD,
		OutputStepSpeed = 0xAE,
		OutputTimeSpeed = 0xAF,
		OutputStepSync = 0xB0,
		OutputTimeSync = 0xB1,
		OutputClrCount = 0xB2,
		OutputGetCount = 0xB3,

		// Memory
		File = 0xC0,
		Array = 0xC1,
		ArrayWrite = 0xC2,
		ArrayRead = 0xC3,
		ArrayAppend = 0xC4,
		MemoryUsage = 0xC5,
		FileName = 0xC6,

		Read8 = 0xC8,
		Read16 = 0xC9,
		Read32 = 0xCA,
		ReadF = 0xCB,

		Write8 = 0xCC,
		Write16 = 0xCD,
		Write32 = 0xCE,
		WriteF = 0xCF,

		ComGet = 0xD3,
		ComSet = 0xD4,

		// Mailbox
		MailboxOpen = 0xD8,
		MailboxWrite = 0xD9,
		MailboxRead = 0xDA,
		MailboxTest = 0xDB,
		MailboxReady = 0xDC,
		MailboxClose = 0xDD
	}
}
