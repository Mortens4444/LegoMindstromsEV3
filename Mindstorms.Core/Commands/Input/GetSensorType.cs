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
                OpCode.InputDevice,
                InputSubCode.GetTypeMode,
                daisyChainLayer,
                sensorPort,
                2,
                ParameterType.Variable | VariableScope.Global
            });
        }
    }
}
