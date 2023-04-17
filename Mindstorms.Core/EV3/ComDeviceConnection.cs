using System;
using System.IO.Ports;

namespace Mindstorms.Core.EV3
{
    public class ComDeviceConnection : IDeviceConnection
    {
        private readonly SerialPort comPort;

        public ComDeviceConnection(string portName)
        {
            comPort = new SerialPort(portName, 115200)
            {
                ReadTimeout = Constants.ReadWriteTimeout,
                WriteTimeout = Constants.ReadWriteTimeout
            };
            comPort.ErrorReceived += ComPort_ErrorReceived;
        }

        public void Connect()
        {
            try
            {
                comPort.Open();
            }
            catch
            {
                // Sometimes the first attempt to connect fails.
                comPort.Open();
            }
        }

        public void Disconnect()
        {
            comPort.Close();
        }

        public void Dispose()
        {
            comPort.Dispose();
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
            throw new Exception($"Error Received from brick: {e.EventType}. Details: {e}");
        }
    }
}
