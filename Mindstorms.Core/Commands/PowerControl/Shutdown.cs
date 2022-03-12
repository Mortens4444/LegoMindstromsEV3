using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.PowerControl
{
    public class Shutdown : Command
    {
        public Shutdown()
        {
            data = DirectCommandNoReply;
            data.AddRange(new byte[]
            {
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
            });
        }
    }
}
