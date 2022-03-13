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
                OpCode.Button,
                ButtonEvent.Press,
                ButtonType.Back,

                OpCode.Button,
                ButtonEvent.WaitForPress,

                OpCode.Button,
                ButtonEvent.Press,
                ButtonType.Right,

                OpCode.Button,
                ButtonEvent.WaitForPress,

                OpCode.Button,
                ButtonEvent.Press,
                ButtonType.Center
            });
        }
    }
}
