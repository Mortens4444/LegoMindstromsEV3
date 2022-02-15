namespace Mindstorms.Core.Enums
{
    public enum SystemInfoSubCommand
    {
        GetBatteryVoltage = 0x01,
        GetBatteryCurrent = 0x02,
        GetOperatingSystemVersion = 0x03,
        GetEvent = 0x04,
        GetBatteryTemperatureRise = 0x05,
        GetMotorCurrent = 0x07,
        GetString = 0x08,
        GetHardwareVersion = 0x09,
        GetFirmwareVersion = 0x0A,
        GetFirmwareBuild = 0x0B,
        GetOperatingSystemBuild = 0x0C,
        GetAddress = 0x0D,
        GetCode = 0x0E,
        Key = 0x0F,
        GetShutdown = 0x10,
        GetWarning = 0x11,
        GetBatteryLevel = 0x12,
        TextboxRead = 0x15,
        GetVersion = 0x1A,
        GetIP = 0x1B,
        GetSDCard = 0x1D,
        GetUSBStick = 0x1E,
        //GetFirmwareBuild = 0x1F
    }
}
