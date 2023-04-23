using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor;

public class StopMotor : Command
{
    public StopMotor(DaisyChainLayer daisyChainLayer, OutputPort outputPort, BreakType breakType)
    {
        data = DirectCommandNoReply;
        data.AddRange(new byte[]
        {
            OpCode.OutputStop,
            daisyChainLayer,
            outputPort,
            breakType
        });
    }
}
