namespace Mindstorms.Core.Enums
{
    public enum ComSetSubCommand : byte
    {
        SetOnOff = 0x01,
        SetVisible = 0x02,
        SetSearch = 0x03,
        SetPin = 0x05,
        SetPasskey = 0x06,
        SetConnection = 0x07,
        SetBrickName = 0x08,
        SetMoveUp = 0x09,
        SetMoveDown = 0x0A,
        SetEncrypt = 0x0B,
        SetSSID = 0x0C
    }
}
