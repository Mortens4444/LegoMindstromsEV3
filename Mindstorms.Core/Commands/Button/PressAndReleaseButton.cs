using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Button;

public class PressAndReleaseButton : Command
{
#warning This command must be tested.

    public PressAndReleaseButton(ButtonType button)
    {
        data = DirectCommandNoReply;
        data.AddRange(new byte[]
        {
            OpCode.Button,
            ButtonEvent.Press,
            button,

            OpCode.Button,
            ButtonEvent.WaitForPress,

            OpCode.Button,
            ButtonEvent.Release,
            button
        });
    }
}
