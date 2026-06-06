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
        var status = await Permissions.RequestAsync<Platforms.Android.BluetoothConnectPermission>();
        if (status != PermissionStatus.Granted)
        {
            return;
        }
#endif
    }
}
