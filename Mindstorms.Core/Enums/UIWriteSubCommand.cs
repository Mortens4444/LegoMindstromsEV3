﻿namespace Mindstorms.Core.Enums;

public class UIWriteSubCommand : EnumLikeObject<UIWriteSubCommand>
{
    public static readonly UIWriteSubCommand WriteFlush = new(0x01, nameof(WriteFlush));
    public static readonly UIWriteSubCommand FloatValue = new(0x02, nameof(FloatValue));
    public static readonly UIWriteSubCommand PutString = new(0x08, nameof(PutString));
    public static readonly UIWriteSubCommand Value8 = new(0x09, nameof(Value8));
    public static readonly UIWriteSubCommand Value16 = new(0x0A, nameof(Value16));
    public static readonly UIWriteSubCommand Value32 = new(0x0B, nameof(Value32));
    public static readonly UIWriteSubCommand ValueF = new(0x0C, nameof(ValueF));
    public static readonly UIWriteSubCommand DownloadEnd = new(0x0F, nameof(DownloadEnd));
    public static readonly UIWriteSubCommand ScreenBlock = new(0x10, nameof(ScreenBlock));
    public static readonly UIWriteSubCommand TextBoxAppend = new(0x15, nameof(TextBoxAppend));
    public static readonly UIWriteSubCommand SetBusy = new(0x16, nameof(SetBusy));
    public static readonly UIWriteSubCommand SetTestPin = new(0x18, nameof(SetTestPin));
    public static readonly UIWriteSubCommand InitRun = new(0x19, nameof(InitRun));
    public static readonly UIWriteSubCommand Led = new(0x1B, nameof(Led));
    public static readonly UIWriteSubCommand Power = new(0x1D, nameof(Power));
    public static readonly UIWriteSubCommand GraphSample = new(0x1E, nameof(GraphSample));
    public static readonly UIWriteSubCommand Terminal = new(0x1F, nameof(Terminal));

    private UIWriteSubCommand(byte value, string name) : base(value, name)
    {
        Values.Add(value, this);
    }

    public static implicit operator UIWriteSubCommand(byte value)
    {
        return Values[value];
    }

    public static implicit operator byte(UIWriteSubCommand value)
    {
        return value.Value;
    }
}
