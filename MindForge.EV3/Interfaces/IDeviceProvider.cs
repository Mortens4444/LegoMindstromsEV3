namespace MindForge.EV3.Interfaces;

public interface IDeviceProvider
{
    Task<IReadOnlyList<string>> GetDevicesAsync();
}
