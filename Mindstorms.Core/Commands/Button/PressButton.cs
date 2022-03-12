using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Button
{
    public class PressButton : Command
    {
#warning This command must be tested.

        public PressButton(ButtonType button)
        {
            data = DirectCommandNoReply;
            data.AddRange(new byte[]
            {
                (byte)OpCode.Button,
                (byte)ButtonEvent.Press,
                (byte)button,

                (byte)OpCode.Button,
                (byte)ButtonEvent.WaitForPress
            });
        }
    }
}
