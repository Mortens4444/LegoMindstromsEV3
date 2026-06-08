using MindForge.EV3.Interfaces;
using MindForge.EV3.Platforms.Android;
using MindForge.EV3.Services;

namespace MindForge.EV3;

public static partial class MauiProgram
{
    static partial void RegisterPlatformServices(IServiceCollection services)
    {
        services.AddBlazorWebViewDeveloperTools();
        services.AddSingleton<IDeviceProvider, AndroidBluetoothProvider>();
    }
}
