using MindForge.EV3.Interfaces;
using MindForge.EV3.Platforms.Windows;

namespace MindForge.EV3;

public static partial class MauiProgram
{
    static partial void RegisterPlatformServices(IServiceCollection services)
    {
        services.AddSingleton<IDeviceProvider, WindowsSerialPortProvider>();
    }
}
