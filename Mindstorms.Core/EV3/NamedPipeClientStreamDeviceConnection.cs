using System.IO.Pipes;

namespace Mindstorms.Core.EV3;

public class NamedPipeClientStreamDeviceConnection : IDeviceConnection
{
    private readonly NamedPipeClientStream namedPipeClientStream;
    private readonly IntPtr pipeHandle;
    private bool disposed;

    public NamedPipeClientStreamDeviceConnection(string machine, string pipeName)
    {
        pipeHandle = NamedPipeCreator.CreatePipe(pipeName);
        namedPipeClientStream = new NamedPipeClientStream(machine, pipeName, PipeDirection.InOut);
    }

    ~NamedPipeClientStreamDeviceConnection()
    {
        Dispose(false);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                namedPipeClientStream.Dispose();
            }
            NamedPipeCreator.ClosePipe(pipeHandle);

            disposed = true;
        }
    }

    public void Connect()
    {
        namedPipeClientStream.Connect();
    }

    public void Disconnect()
    {
        namedPipeClientStream.Close();
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
