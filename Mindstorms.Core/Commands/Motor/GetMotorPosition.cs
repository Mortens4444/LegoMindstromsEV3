using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
#warning This command must be tested.

    public class GetMotorPosition : Command
    {
        public GetMotorPosition(OutputPort outputPort, MotorType motorType, DaisyChainLayer daisyChainLayer)
        {
            data = GetDirectCommandWithReply(4);
            data.AddRange(new byte[]
            {
                (byte)OpCode.InputDevice,
                (byte)InputSubCode.ReadyRaw,
                (byte)daisyChainLayer,
                (byte)outputPort,
                (byte)motorType,
                (byte)MotorMode.Degree,
                1,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            });
        }
    }
}
