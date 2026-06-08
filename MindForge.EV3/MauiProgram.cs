using Microsoft.Extensions.Logging;
using MindForge.EV3.Interfaces;
using MindForge.EV3.Services;

namespace MindForge.EV3;

public static partial class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();

        RegisterPlatformServices(builder.Services);
        builder.Services.AddSingleton<IBluetoothConnectionFactory, BluetoothConnectionFactory>();


#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

        return builder.Build();
    }

    static partial void RegisterPlatformServices(IServiceCollection services);
}
