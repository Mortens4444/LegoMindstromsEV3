namespace Mindstorms.Core.Enums;

public class SystemInfoSubCommand : EnumLikeObject<SystemInfoSubCommand>
{
    public static readonly SystemInfoSubCommand GetBatteryVoltage = new(0x01, nameof(GetBatteryVoltage));
    public static readonly SystemInfoSubCommand GetBatteryCurrent = new(0x02, nameof(GetBatteryCurrent));
    public static readonly SystemInfoSubCommand GetOperatingSystemVersion = new(0x03, nameof(GetOperatingSystemVersion));
    public static readonly SystemInfoSubCommand GetEvent = new(0x04, nameof(GetEvent));
    public static readonly SystemInfoSubCommand GetBatteryTemperatureRise = new(0x05, nameof(GetBatteryTemperatureRise));
    public static readonly SystemInfoSubCommand GetMotorCurrent = new(0x07, nameof(GetMotorCurrent));
    public static readonly SystemInfoSubCommand GetString = new(0x08, nameof(GetString));
    public static readonly SystemInfoSubCommand GetHardwareVersion = new(0x09, nameof(GetHardwareVersion));
    public static readonly SystemInfoSubCommand GetFirmwareVersion = new(0x0A, nameof(GetFirmwareVersion));
    public static readonly SystemInfoSubCommand GetFirmwareBuild = new(0x0B, nameof(GetFirmwareBuild));
    public static readonly SystemInfoSubCommand GetOperatingSystemBuild = new(0x0C, nameof(GetOperatingSystemBuild));
    public static readonly SystemInfoSubCommand GetAddress = new(0x0D, nameof(GetAddress));
    public static readonly SystemInfoSubCommand GetCode = new(0x0E, nameof(GetCode));
    public static readonly SystemInfoSubCommand Key = new(0x0F, nameof(Key));
    public static readonly SystemInfoSubCommand GetShutdown = new(0x10, nameof(GetShutdown));
    public static readonly SystemInfoSubCommand GetWarning = new(0x11, nameof(GetWarning));
    public static readonly SystemInfoSubCommand GetBatteryLevel = new(0x12, nameof(GetBatteryLevel));
    public static readonly SystemInfoSubCommand TextboxRead = new(0x15, nameof(TextboxRead));
    public static readonly SystemInfoSubCommand GetVersion = new(0x1A, nameof(GetVersion));
    public static readonly SystemInfoSubCommand GetIP = new(0x1B, nameof(GetIP));
    public static readonly SystemInfoSubCommand GetSDCard = new(0x1D, nameof(GetSDCard));
    public static readonly SystemInfoSubCommand GetUSBStick = new(0x1E, nameof(GetUSBStick));
    //public static readonly SystemInfoSubCommand GetFirmwareBuild = new(0x1F, nameof(GetFirmwareBuild));

    private SystemInfoSubCommand(byte value, string name) : base(value, name)
    {
        Values.Add(value, this);
    }

    public static implicit operator SystemInfoSubCommand(byte value)
    {
        return Values[value];
    }

    public static implicit operator byte(SystemInfoSubCommand value)
    {
        return value.Value;
    }
}
