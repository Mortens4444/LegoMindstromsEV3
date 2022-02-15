using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
#warning This command must be tested.

    public class GetMotorPosition : Command
    {
        public GetMotorPosition(OutputPort outputPort, MotorType motorType)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                4,
                0,

                (byte)OpCode.InputDevice,
                (byte)InputSubCode.ReadyRaw,
                (byte)DaisyChainLayer.EV3,
                (byte)outputPort,
                (byte)motorType,
                (byte)MotorMode.Degree,
                1,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
