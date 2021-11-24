namespace Mindstorms.Core.Enums
{
    public enum ButtonEvent
    {
        ShortPress = 0x01,
        LongPress = 0x02,
        WaitForPress = 0x03,
        Flush = 0x04,
        Press = 0x05,
        Release = 0x06,
        GetHoizontalArrowsState = 0x07,
        GetVerticalArrowsState = 0x08,
        Pressed = 0x09,
        SetBackButtonBlock = 0x0A,
        GetBackButtonBlock = 0x0B,
        TestShortPress = 0x0C,
        TestLongPress = 0x0D,
        GetBumped = 0x0E,
        GetClick = 0x0F
    }
}
