namespace MindForge.EV3.Platforms.Android;

public class BluetoothConnectPermission : Permissions.BasePlatformPermission
{
#if ANDROID
    public override (string androidPermission, bool isRuntime)[] RequiredPermissions =>
    [
        (global::Android.Manifest.Permission.BluetoothConnect, true)
    ];
#endif
}
