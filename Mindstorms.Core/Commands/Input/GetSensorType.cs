using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Input
{
    public class GetSensorType : Command
    {
        public GetSensorType(SensorPort sensorPort, DaisyChainLayer daisyChainLayer)
        {
            data = GetDirectCommandWithReply(2);
            data.AddRange(new byte[]
            {
                (byte)OpCode.InputDevice,
                (byte)InputSubCode.GetTypeMode,
                (byte)daisyChainLayer,
                (byte)sensorPort,
                2,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            });
        }
    }
}
