using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor;

public class WaitForFinish : Command
{
#warning This command must be tested.

    public WaitForFinish(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
    {
        data = DirectCommandNoReply;
        data.AddRange(new byte[]
        {
            OpCode.OutputReady,
            daisyChainLayer,
            outputPort
        });
    }
}
