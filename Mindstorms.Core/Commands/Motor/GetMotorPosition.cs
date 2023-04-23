using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor;

#warning This command must be tested.

public class GetMotorPosition : Command
{
    public GetMotorPosition(OutputPort outputPort, MotorType motorType, DaisyChainLayer daisyChainLayer)
    {
        data = GetDirectCommandWithReply(4);
        data.AddRange(new byte[]
        {
            OpCode.InputDevice,
            InputSubCode.ReadyRaw,
            daisyChainLayer,
            outputPort,
            motorType,
            MotorMode.Degree,
            1,
            ParameterType.Variable | VariableScope.Global
        });
    }
}
