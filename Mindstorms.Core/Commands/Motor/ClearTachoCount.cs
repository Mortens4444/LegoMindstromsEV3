using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class ClearTachoCount : Command
    {
#warning This command must be tested.

        public ClearTachoCount(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
        {
            data = DirectCommandNoReply;
            data.AddRange(new byte[]
            {
                OpCode.OutputClrCount,
                daisyChainLayer,
                outputPort
            });
        }
    }
}
