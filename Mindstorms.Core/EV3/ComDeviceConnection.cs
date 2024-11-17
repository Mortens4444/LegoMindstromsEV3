using System.IO.Ports;

namespace Mindstorms.Core.EV3;

public class ComDeviceConnection : IDeviceConnection
{
    private readonly SerialPort comPort;
    private bool disposed;

    public ComDeviceConnection(string portName)
    {
        comPort = new SerialPort(portName, 115200)
        {
            ReadTimeout = Constants.ReadWriteTimeout,
            WriteTimeout = Constants.ReadWriteTimeout
        };
        comPort.ErrorReceived += ComPort_ErrorReceived;
    }

    ~ComDeviceConnection()
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
                comPort.Dispose();
            }

            disposed = true;
        }
    }

    public void Connect()
    {
        comPort.Open();
    }

    public void Disconnect()
    {
        if (comPort.IsOpen)
        {
            comPort.Close();
        }
    }

    public int Read(byte[] buffer, int offset, int count)
    {
        return comPort.Read(buffer, offset, count);
    }

    public void Write(byte[] buffer, int offset, int count)
    {
        comPort.Write(buffer, offset, count);
    }

    private void ComPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
    {
        throw new InvalidOperationException($"Error Received from brick: {e.EventType}. Details: {e}");
    }
}
