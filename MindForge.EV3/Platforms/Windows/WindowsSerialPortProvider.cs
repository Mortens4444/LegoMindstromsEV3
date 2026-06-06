using MindForge.EV3.Interfaces;
using System.IO.Ports;

namespace MindForge.EV3.Platforms.Windows;

public class WindowsSerialPortProvider : IDeviceProvider
{
    public Task<IReadOnlyList<string>> GetDevicesAsync()
    {
        try
        {
            var ports = SerialPort.GetPortNames().OrderBy(x => x).ToList();
            return Task.FromResult<IReadOnlyList<string>>(ports);
        }
        catch (Exception ex)
        {
            return Task.FromException<IReadOnlyList<string>>(ex);
        }
    }
}
