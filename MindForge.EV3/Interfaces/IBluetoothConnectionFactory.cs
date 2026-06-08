using Mtf.Lego.Mindstorms.EV3.EV3;

namespace MindForge.EV3.Interfaces;

public interface IBluetoothConnectionFactory
{
    IDeviceConnection Create(string deviceInfo);
}
