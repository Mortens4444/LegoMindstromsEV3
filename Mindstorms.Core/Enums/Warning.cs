namespace Mindstorms.Core.Enums;

[Flags]
public enum Warning
{
    WarningTemperature = 0x01,
    WarningCurrent = 0x02,
    WarningVoltage = 0x04,
    WarningMemory = 0x08,
    WarningDSPSTAT = 0x10,
    WarningRAM = 0x20,
    WarningBatteryLow = 0x40,
    WarningBusy = 0x80,
    Warnings = 0x3F
}
