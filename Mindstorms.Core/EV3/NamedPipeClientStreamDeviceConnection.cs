using System.IO.Pipes;

namespace Mindstorms.Core.EV3;

public class NamedPipeClientStreamDeviceConnection : IDeviceConnection
{
    private readonly NamedPipeClientStream namedPipeClientStream;
    private readonly IntPtr pipeHandle;

    public NamedPipeClientStreamDeviceConnection(string machine, string pipeName)
    {
        pipeHandle = NamedPipeCreator.CreatePipe(pipeName);
        namedPipeClientStream = new NamedPipeClientStream(machine, pipeName, PipeDirection.InOut);
    }

    public void Connect()
    {
        namedPipeClientStream.Connect();
    }

    public void Disconnect()
    {
        namedPipeClientStream.Close();
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        NamedPipeCreator.ClosePipe(pipeHandle);
        namedPipeClientStream.Dispose();
    }

    public int Read(byte[] buffer, int offset, int count)
    {
        return namedPipeClientStream.Read(buffer, offset, count);
    }

    public void Write(byte[] buffer, int offset, int count)
    {
        namedPipeClientStream.Write(buffer, offset, count);
    }
}
