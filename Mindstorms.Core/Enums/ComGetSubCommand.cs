namespace Mindstorms.Core.Enums
{
    public enum ComGetSubCommand : byte
    {
        GetOnOff = 0x01,
        GetVisible = 0x02,
        GetResult = 0x04,
        GetPin = 0x05,
        SearchItems = 0x08,
        SearchItem = 0x09,
        FavourItems = 0x0A,
        FavourItem = 0x0B,
        GetId = 0x0C,
        GetBrickName = 0x0D,
        GetNetwork = 0x0E,
        GetPresent = 0x0F,
        GetEncrypt = 0x10,
        GetIncomming = 0x11,
    }
}
