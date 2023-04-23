using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor;

public class OutputPower : Command
{
    public OutputPower(DaisyChainLayer daisyChainLayer, OutputPort outputPort, byte power)
    {
        data = DirectCommandNoReply;
        data.AddRange(new byte[]
        {
            OpCode.OutputPower,
            daisyChainLayer,
            outputPort,
            power
        });
    }
}
