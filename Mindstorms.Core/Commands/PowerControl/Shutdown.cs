using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.PowerControl
{
    public class Shutdown : Command
    {
        public Shutdown()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Press,
                (byte)ButtonType.Back,

                (byte)OpCode.Button,
                (byte)ButtonEvent.WaitForPress,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Press,
                (byte)ButtonType.Right,

                (byte)OpCode.Button,
                (byte)ButtonEvent.WaitForPress,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Press,
                (byte)ButtonType.Center
            };
        }
    }
}
