namespace Mindstorms.Core.Enums;

public enum InfraredBeaconButtonsCombination
{
    NoButtonPressed = 0x00,
    RedUpper = 0x01,
    RedLower = 0x02,
    BlueUpper = 0x03,
    BlueLower = 0x04,
    RedUpperAndBlueUpper = 0x05,
    RedUpperAndBlueLower = 0x06,
    RedLowerAndBlueUpper = 0x07,
    RedLowerAndBlueLower = 0x08,
    Beacon = 0x09,
    RedUpperAndRedLower = 0x0A,
    BlueUpperAndBlueLower = 0x0B
}
