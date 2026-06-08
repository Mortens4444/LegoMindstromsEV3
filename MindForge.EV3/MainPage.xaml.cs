#if ANDROID
using MindForge.EV3.Platforms.Android;
#endif

namespace MindForge.EV3;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

#if ANDROID
        await Task.Delay(300);

        var scanStatus = await Permissions.CheckStatusAsync<BluetoothScanPermission>();
        if (scanStatus != PermissionStatus.Granted)
        {
            scanStatus = await Permissions.RequestAsync<BluetoothScanPermission>();
        }

        var connectStatus = await Permissions.CheckStatusAsync<BluetoothConnectPermission>();
        if (connectStatus != PermissionStatus.Granted)
        {
            connectStatus = await Permissions.RequestAsync<BluetoothConnectPermission>();
        }
#endif
    }
}
