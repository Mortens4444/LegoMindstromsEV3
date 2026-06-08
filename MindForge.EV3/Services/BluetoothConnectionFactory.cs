using MindForge.EV3.Interfaces;

#if ANDROID
using MindForge.EV3.Platforms.Android;
#elif WINDOWS
using MindForge.EV3.Platforms.Windows;
#endif

using Mtf.Lego.Mindstorms.EV3.EV3;

namespace MindForge.EV3.Services;

public class BluetoothConnectionFactory : IBluetoothConnectionFactory
{
    public IDeviceConnection Create(string deviceInfo)
    {
#if ANDROID
        return new AndroidBluetoothConnection(ExtractMacAddress(deviceInfo));
#elif WINDOWS
        return new ComDeviceConnection(deviceInfo);
#else
        throw new NotSupportedException("Unsupported platform.");
#endif
    }

#if ANDROID
    private static string ExtractMacAddress(string deviceInfo)
    {
        if (String.IsNullOrWhiteSpace(deviceInfo))
        {
            return String.Empty;
        }

        int startIndex = deviceInfo.LastIndexOf('[');
        int endIndex = deviceInfo.LastIndexOf(']');

        if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
        {
            return deviceInfo.Substring(startIndex + 1, endIndex - startIndex - 1);
        }

        return String.Empty;
    }
#endif
}