using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Button
{
    public class PressAndReleaseButton : Command
    {
#warning This command must be tested.

        public PressAndReleaseButton(ButtonType button)
        {
            data = DirectCommandNoReply;
            data.AddRange(new byte[]
            {
                (byte)OpCode.Button,
                (byte)ButtonEvent.Press,
                (byte)button,

                (byte)OpCode.Button,
                (byte)ButtonEvent.WaitForPress,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Release,
                (byte)button
            });
        }
    }
}
