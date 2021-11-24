namespace Mindstorms.Core.Enums
{
    public enum UIWriteSubCommand
    {
        WriteFlush = 0x01,
        FloatValue = 0x02,
        PutString = 0x08,
        Value8 = 0x09,
        Value16 = 0x0A,
        Value32 = 0x0B,
        ValueF = 0x0C,
        DownloadEnd = 0x0F,
        ScreenBlock = 0x10,
        TextBoxAppend = 0x15,
        SetBusy = 0x16,
        SetTestPin = 0x18,
        InitRun = 0x19,
        Led = 0x1B,
        Power = 0x1D,
        GraphSample = 0x1E,
        Terminal = 0x1F
    }
}
