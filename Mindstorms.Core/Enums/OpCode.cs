namespace Mindstorms.Core.Enums
{
    public class OpCode : EnumLikeObject<OpCode>
	{

		public static readonly OpCode Error = new OpCode(0x00, nameof(Error));
		public static readonly OpCode Nop = new OpCode(0x01, nameof(Nop));

		public static readonly OpCode ProgramStop = new OpCode(0x02, nameof(ProgramStop));
		public static readonly OpCode ProgramStart = new OpCode(0x03, nameof(ProgramStart));

		public static readonly OpCode ObjectStop = new OpCode(0x04, nameof(ObjectStop));
		public static readonly OpCode ObjectStart = new OpCode(0x05, nameof(ObjectStart));
		public static readonly OpCode ObjectTrigger = new OpCode(0x06, nameof(ObjectTrigger));
		public static readonly OpCode ObjectWait = new OpCode(0x07, nameof(ObjectWait));

		public static readonly OpCode Return = new OpCode(0x08, nameof(Return));
		public static readonly OpCode Call = new OpCode(0x09, nameof(Call));
		public static readonly OpCode ObjectEnd = new OpCode(0x0A, nameof(ObjectEnd));
		public static readonly OpCode Sleep = new OpCode(0x0B, nameof(Sleep));

		public static readonly OpCode ProgramInfo = new OpCode(0x0C, nameof(ProgramInfo));
		
		public static readonly OpCode Label = new OpCode(0x0D, nameof(Label));
		public static readonly OpCode Probe = new OpCode(0x0E, nameof(Probe));
		public static readonly OpCode Do = new OpCode(0x0F, nameof(Do));

		public static readonly OpCode Add8 = new OpCode(0x10, nameof(Add8));
		public static readonly OpCode Add16 = new OpCode(0x11, nameof(Add16));
		public static readonly OpCode Add32 = new OpCode(0x12, nameof(Add32));
		public static readonly OpCode AddFloat = new OpCode(0x13, nameof(AddFloat));

		public static readonly OpCode Sub8 = new OpCode(0x14, nameof(Sub8));
		public static readonly OpCode Sub16 = new OpCode(0x15, nameof(Sub16));
		public static readonly OpCode Sub32 = new OpCode(0x16, nameof(Sub32));
		public static readonly OpCode SubFloat = new OpCode(0x17, nameof(SubFloat));

		public static readonly OpCode Mul8 = new OpCode(0x18, nameof(Mul8));
		public static readonly OpCode Mul16 = new OpCode(0x19, nameof(Mul16));
		public static readonly OpCode Mul32 = new OpCode(0x1A, nameof(Mul32));
		public static readonly OpCode MulFloat = new OpCode(0x1B, nameof(MulFloat));

		public static readonly OpCode Div8 = new OpCode(0x1C, nameof(Div8));
		public static readonly OpCode Div16 = new OpCode(0x1D, nameof(Div16));
		public static readonly OpCode Div32 = new OpCode(0x1E, nameof(Div32));
		public static readonly OpCode DivFloat = new OpCode(0x1F, nameof(DivFloat));

		public static readonly OpCode Or8 = new OpCode(0x20, nameof(Or8));
		public static readonly OpCode Or16 = new OpCode(0x21, nameof(Or16));
		public static readonly OpCode Or32 = new OpCode(0x22, nameof(Or32));

		public static readonly OpCode And8 = new OpCode(0x24, nameof(And8));
		public static readonly OpCode And16 = new OpCode(0x25, nameof(And16));
		public static readonly OpCode And32 = new OpCode(0x26, nameof(And32));

		public static readonly OpCode Xor8 = new OpCode(0x28, nameof(Xor8));
		public static readonly OpCode Xor16 = new OpCode(0x29, nameof(Xor16));
		public static readonly OpCode Xor32 = new OpCode(0x2A, nameof(Xor32));

		public static readonly OpCode Rotate8 = new OpCode(0x2C, nameof(Rotate8));
		public static readonly OpCode Rotate16 = new OpCode(0x2D, nameof(Rotate16));
		public static readonly OpCode Rotate32 = new OpCode(0x2E, nameof(Rotate32));

		public static readonly OpCode InitBytes = new OpCode(0x2F, nameof(InitBytes));

		public static readonly OpCode Move8_8 = new OpCode(0x30, nameof(Move8_8));
		public static readonly OpCode Move8_16 = new OpCode(0x31, nameof(Move8_16));
		public static readonly OpCode Move8_32 = new OpCode(0x32, nameof(Move8_32));
		public static readonly OpCode Move8_F = new OpCode(0x33, nameof(Move8_F));

		public static readonly OpCode Move16_8 = new OpCode(0x34, nameof(Move16_8));
		public static readonly OpCode Move16_16 = new OpCode(0x35, nameof(Move16_16));
		public static readonly OpCode Move16_32 = new OpCode(0x36, nameof(Move16_32));
		public static readonly OpCode Move16_F = new OpCode(0x37, nameof(Move16_F));

		public static readonly OpCode Move32_8 = new OpCode(0x38, nameof(Move32_8));
		public static readonly OpCode Move32_16 = new OpCode(0x39, nameof(Move32_16));
		public static readonly OpCode Move32_32 = new OpCode(0x3A, nameof(Move32_32));
		public static readonly OpCode Move32_F = new OpCode(0x3B, nameof(Move32_F));

		public static readonly OpCode MoveF_8 = new OpCode(0x3C, nameof(MoveF_8));
		public static readonly OpCode MoveF_16 = new OpCode(0x3D, nameof(MoveF_16));
		public static readonly OpCode MoveF_32 = new OpCode(0x3E, nameof(MoveF_32));
		public static readonly OpCode MoveF_F = new OpCode(0x3F, nameof(MoveF_F));

		public static readonly OpCode Jr = new OpCode(0x40, nameof(Jr));

		public static readonly OpCode System = new OpCode(0x60, nameof(System));
		public static readonly OpCode PortConvOutput = new OpCode(0x61, nameof(PortConvOutput));
		public static readonly OpCode PortConvInput = new OpCode(0x62, nameof(PortConvInput));
		public static readonly OpCode NoteToFrequency = new OpCode(0x63, nameof(NoteToFrequency));

		public static readonly OpCode Info = new OpCode(0x7C, nameof(Info));
		public static readonly OpCode String = new OpCode(0x7D, nameof(String));
		public static readonly OpCode MemoryWrite = new OpCode(0x7E, nameof(MemoryWrite));
		public static readonly OpCode MemoryRead = new OpCode(0x7F, nameof(MemoryRead));

		public static readonly OpCode UIRead = new OpCode(0x81, nameof(UIRead));
		public static readonly OpCode UIWrite = new OpCode(0x82, nameof(UIWrite));
		public static readonly OpCode Button = new OpCode(0x83, nameof(Button));
		public static readonly OpCode DrawUI = new OpCode(0x84, nameof(DrawUI));
		public static readonly OpCode BP0 = new OpCode(0x88, nameof(BP0));
		public static readonly OpCode BP1 = new OpCode(0x89, nameof(BP1));
		public static readonly OpCode BP2 = new OpCode(0x8A, nameof(BP2));
		public static readonly OpCode BP3 = new OpCode(0x8B, nameof(BP3));
		public static readonly OpCode PBSet = new OpCode(0x8C, nameof(PBSet));
		public static readonly OpCode Math = new OpCode(0x8D, nameof(Math));
		public static readonly OpCode Random = new OpCode(0x8E, nameof(Random));

		public static readonly OpCode KeepAlive = new OpCode(0x90, nameof(KeepAlive));

		public static readonly OpCode Sound = new OpCode(0x94, nameof(Sound));
		public static readonly OpCode SoundTest = new OpCode(0x95, nameof(SoundTest));
		public static readonly OpCode SoundReady = new OpCode(0x96, nameof(SoundReady));

		public static readonly OpCode InputSample = new OpCode(0x97, nameof(InputSample));
		public static readonly OpCode InputDeviceList = new OpCode(0x98, nameof(InputDeviceList));
		public static readonly OpCode InputDevice = new OpCode(0x99, nameof(InputDevice));
		public static readonly OpCode InputRead = new OpCode(0x9A, nameof(InputRead));
		public static readonly OpCode InputTest = new OpCode(0x9B, nameof(InputTest));
		public static readonly OpCode InputReady = new OpCode(0x9C, nameof(InputReady));
		public static readonly OpCode InputReadSI = new OpCode(0x9D, nameof(InputReadSI));
		public static readonly OpCode InputReadExt = new OpCode(0x9E, nameof(InputReadExt));
		public static readonly OpCode InputWrite = new OpCode(0x9F, nameof(InputWrite));

		public static readonly OpCode OutputGetType = new OpCode(0xA0, nameof(OutputGetType));
		public static readonly OpCode OutputSetType = new OpCode(0xA1, nameof(OutputSetType));
		public static readonly OpCode OutputReset = new OpCode(0xA2, nameof(OutputReset));
		public static readonly OpCode OutputStop = new OpCode(0xA3, nameof(OutputStop));
		public static readonly OpCode OutputPower = new OpCode(0xA4, nameof(OutputPower));
		public static readonly OpCode OutputSpeed = new OpCode(0xA5, nameof(OutputSpeed));
		public static readonly OpCode OutputStart = new OpCode(0xA6, nameof(OutputStart));
		public static readonly OpCode OutputPolarity = new OpCode(0xA7, nameof(OutputPolarity));
		public static readonly OpCode OutputRead = new OpCode(0xA8, nameof(OutputRead));
		public static readonly OpCode OutputTest = new OpCode(0xA9, nameof(OutputTest));
		public static readonly OpCode OutputReady = new OpCode(0xAA, nameof(OutputReady));
		public static readonly OpCode OutputPosition = new OpCode(0xAB, nameof(OutputPosition));
		public static readonly OpCode OutputStepPower = new OpCode(0xAC, nameof(OutputStepPower));
		public static readonly OpCode OutputTimePower = new OpCode(0xAD, nameof(OutputTimePower));
		public static readonly OpCode OutputStepSpeed = new OpCode(0xAE, nameof(OutputStepSpeed));
		public static readonly OpCode OutputTimeSpeed = new OpCode(0xAF, nameof(OutputTimeSpeed));
		public static readonly OpCode OutputStepSync = new OpCode(0xB0, nameof(OutputStepSync));
		public static readonly OpCode OutputTimeSync = new OpCode(0xB1, nameof(OutputTimeSync));
		public static readonly OpCode OutputClrCount = new OpCode(0xB2, nameof(OutputClrCount));
		public static readonly OpCode OutputGetCount = new OpCode(0xB3, nameof(OutputGetCount));
		public static readonly OpCode OutputPrgStop = new OpCode(0xB4, nameof(OutputPrgStop));

		public static readonly OpCode File = new OpCode(0xC0, nameof(File));
		public static readonly OpCode Array = new OpCode(0xC1, nameof(Array));
		public static readonly OpCode ArrayWrite = new OpCode(0xC2, nameof(ArrayWrite));
		public static readonly OpCode ArrayRead = new OpCode(0xC3, nameof(ArrayRead));
		public static readonly OpCode ArrayAppend = new OpCode(0xC4, nameof(ArrayAppend));
		public static readonly OpCode MemoryUsage = new OpCode(0xC5, nameof(MemoryUsage));
		public static readonly OpCode FileName = new OpCode(0xC6, nameof(FileName));

		public static readonly OpCode Read8 = new OpCode(0xC8, nameof(Read8));
		public static readonly OpCode Read16 = new OpCode(0xC9, nameof(Read16));
		public static readonly OpCode Read32 = new OpCode(0xCA, nameof(Read32));
		public static readonly OpCode ReadF = new OpCode(0xCB, nameof(ReadF));

		public static readonly OpCode Write8 = new OpCode(0xCC, nameof(Write8));
		public static readonly OpCode Write16 = new OpCode(0xCD, nameof(Write16));
		public static readonly OpCode Write32 = new OpCode(0xCE, nameof(Write32));
		public static readonly OpCode WriteF = new OpCode(0xCF, nameof(WriteF));

		public static readonly OpCode ComTest = new OpCode(0xD1, nameof(ComTest));
		public static readonly OpCode ComGet = new OpCode(0xD3, nameof(ComGet));
		public static readonly OpCode ComSet = new OpCode(0xD4, nameof(ComSet));

		public static readonly OpCode MailboxOpen = new OpCode(0xD8, nameof(MailboxOpen));
		public static readonly OpCode MailboxWrite = new OpCode(0xD9, nameof(MailboxWrite));
		public static readonly OpCode MailboxRead = new OpCode(0xDA, nameof(MailboxRead));
		public static readonly OpCode MailboxTest = new OpCode(0xDB, nameof(MailboxTest));
		public static readonly OpCode MailboxReady = new OpCode(0xDC, nameof(MailboxReady));
		public static readonly OpCode MailboxClose = new OpCode(0xDD, nameof(MailboxClose));

		private OpCode(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator OpCode(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(OpCode value)
		{
			return value.Value;
		}
	}
}
