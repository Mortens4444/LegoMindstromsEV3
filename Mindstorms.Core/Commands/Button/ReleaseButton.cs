using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Button
{
    public class ReleaseButton : Command
    {
#warning This command must be tested.

        public ReleaseButton(ButtonType button)
        {
            data = DirectCommandNoReply;
            data.AddRange(new byte[]
            {
                OpCode.Button,
                ButtonEvent.Release,
                button
            });
        }
    }
}
