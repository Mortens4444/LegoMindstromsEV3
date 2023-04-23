using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor;

public class MotorIsBusy : Command
{
#warning This command must be tested.

    public MotorIsBusy(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
    {
        data = GetDirectCommandWithReply(1);
        data.AddRange(new byte[]
        {
            OpCode.OutputTest,
            daisyChainLayer,
            outputPort,
            ParameterType.Variable | VariableScope.Global
        });
    }
}
