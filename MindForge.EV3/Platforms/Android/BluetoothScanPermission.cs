namespace MindForge.EV3.Platforms.Android;

public class BluetoothScanPermission : Permissions.BasePlatformPermission
{
#if ANDROID
    public override (string androidPermission, bool isRuntime)[] RequiredPermissions =>
    [
        (global::Android.Manifest.Permission.BluetoothScan, true)
    ];
#endif
}
