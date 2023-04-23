namespace Mindstorms.Core.EV3;

public interface IDeviceConnection : IDisposable
{
    void Connect();

    void Disconnect();

    int Read(byte[] buffer, int offset, int count);

    void Write(byte[] buffer, int offset, int count);
}
