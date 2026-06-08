using Android.Bluetooth;
using Java.Util;
using Mtf.Lego.Mindstorms.EV3.EV3;

namespace MindForge.EV3.Platforms.Android;

public class AndroidBluetoothConnection(string macAddress) : IDeviceConnection
{
    private BluetoothSocket socket;
    private readonly string macAddress = macAddress;
    // Standard Serial Port Profile (SPP) UUID used by EV3
    private readonly UUID sppUuid = UUID.FromString("00001101-0000-1000-8000-00805f9b34fb");

    public void Connect()
    {
        var adapter = BluetoothAdapter.DefaultAdapter;
        var device = adapter.GetRemoteDevice(macAddress);

        // Create the RFCOMM socket
        socket = device.CreateRfcommSocketToServiceRecord(sppUuid);

        // Discovery is resource intensive, ensure it's canceled before connecting
        adapter.CancelDiscovery();

        // Connect to the EV3
        socket.Connect();
    }

    public void Disconnect()
    {
        socket?.Close();
        socket?.Dispose();
    }

    // You will need to expose the Input/Output streams for your Brick class to read/write byte arrays
    public Stream InputStream => socket?.InputStream;
    public Stream OutputStream => socket?.OutputStream;

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        Disconnect();
    }

    public int Read(byte[] buffer, int offset, int count)
    {
        if (socket?.InputStream == null || !socket.IsConnected)
        {
            throw new InvalidOperationException("Cannot read: Not connected to the EV3 brick.");
        }

        // Read directly from the Bluetooth socket's input stream
        return socket.InputStream.Read(buffer, offset, count);
    }

    public void Write(byte[] buffer, int offset, int count)
    {
        if (socket?.OutputStream == null || !socket.IsConnected)
        {
            throw new InvalidOperationException("Cannot write: Not connected to the EV3 brick.");
        }

        // Write to the stream
        socket.OutputStream.Write(buffer, offset, count);

        // Ensure the data is actually pushed over the Bluetooth radio immediately
        socket.OutputStream.Flush();
    }
}