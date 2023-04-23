using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor;

public class GetSpeedAndTachoCountLevel : Command
{
#warning This command must be tested.

    public GetSpeedAndTachoCountLevel(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
    {
        data = GetDirectCommandWithReply(5);
        data.AddRange(new byte[]
        {
            OpCode.OutputRead,
            daisyChainLayer,
            outputPort,
            ParameterType.Variable | VariableScope.Global,
            1 | ParameterType.Variable | VariableScope.Global,
        });
    }
}
