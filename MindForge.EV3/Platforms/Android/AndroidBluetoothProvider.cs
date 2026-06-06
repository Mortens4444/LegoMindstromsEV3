using Android.Bluetooth;
using MindForge.EV3.Interfaces;

namespace MindForge.EV3.Platforms.Android;

public class AndroidBluetoothProvider : IDeviceProvider
{
    public async Task<IReadOnlyList<string>> GetDevicesAsync()
    {
        var result = new List<string>();
        var adapter = BluetoothAdapter.DefaultAdapter;
        if (adapter?.IsEnabled == true)
        {
            foreach (var device in adapter.BondedDevices)
            {
                result.Add($"{device.Name} [{device.Address}]");
            }
        }

        return result;
    }
}