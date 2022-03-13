namespace Mindstorms.Core.Enums
{
    public class SystemInfoSubCommand : EnumLikeObject<SystemInfoSubCommand>
    {
        public static readonly SystemInfoSubCommand GetBatteryVoltage = new SystemInfoSubCommand(0x01, nameof(GetBatteryVoltage));
        public static readonly SystemInfoSubCommand GetBatteryCurrent = new SystemInfoSubCommand(0x02, nameof(GetBatteryCurrent));
        public static readonly SystemInfoSubCommand GetOperatingSystemVersion = new SystemInfoSubCommand(0x03, nameof(GetOperatingSystemVersion));
        public static readonly SystemInfoSubCommand GetEvent = new SystemInfoSubCommand(0x04, nameof(GetEvent));
        public static readonly SystemInfoSubCommand GetBatteryTemperatureRise = new SystemInfoSubCommand(0x05, nameof(GetBatteryTemperatureRise));
        public static readonly SystemInfoSubCommand GetMotorCurrent = new SystemInfoSubCommand(0x07, nameof(GetMotorCurrent));
        public static readonly SystemInfoSubCommand GetString = new SystemInfoSubCommand(0x08, nameof(GetString));
        public static readonly SystemInfoSubCommand GetHardwareVersion = new SystemInfoSubCommand(0x09, nameof(GetHardwareVersion));
        public static readonly SystemInfoSubCommand GetFirmwareVersion = new SystemInfoSubCommand(0x0A, nameof(GetFirmwareVersion));
        public static readonly SystemInfoSubCommand GetFirmwareBuild = new SystemInfoSubCommand(0x0B, nameof(GetFirmwareBuild));
        public static readonly SystemInfoSubCommand GetOperatingSystemBuild = new SystemInfoSubCommand(0x0C, nameof(GetOperatingSystemBuild));
        public static readonly SystemInfoSubCommand GetAddress = new SystemInfoSubCommand(0x0D, nameof(GetAddress));
        public static readonly SystemInfoSubCommand GetCode = new SystemInfoSubCommand(0x0E, nameof(GetCode));
        public static readonly SystemInfoSubCommand Key = new SystemInfoSubCommand(0x0F, nameof(Key));
        public static readonly SystemInfoSubCommand GetShutdown = new SystemInfoSubCommand(0x10, nameof(GetShutdown));
        public static readonly SystemInfoSubCommand GetWarning = new SystemInfoSubCommand(0x11, nameof(GetWarning));
        public static readonly SystemInfoSubCommand GetBatteryLevel = new SystemInfoSubCommand(0x12, nameof(GetBatteryLevel));
        public static readonly SystemInfoSubCommand TextboxRead = new SystemInfoSubCommand(0x15, nameof(TextboxRead));
        public static readonly SystemInfoSubCommand GetVersion = new SystemInfoSubCommand(0x1A, nameof(GetVersion));
        public static readonly SystemInfoSubCommand GetIP = new SystemInfoSubCommand(0x1B, nameof(GetIP));
        public static readonly SystemInfoSubCommand GetSDCard = new SystemInfoSubCommand(0x1D, nameof(GetSDCard));
        public static readonly SystemInfoSubCommand GetUSBStick = new SystemInfoSubCommand(0x1E, nameof(GetUSBStick));
        //public static readonly SystemInfoSubCommand GetFirmwareBuild = new SystemInfoSubCommand(0x1F, nameof(GetFirmwareBuild));

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
}
