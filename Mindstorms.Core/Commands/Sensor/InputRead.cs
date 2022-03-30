using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Sensor
{
    public class InputRead : Command
    {
        public InputRead(DaisyChainLayer daisyChainLayer, SensorPort sensorPort)
        {
            data = GetDirectCommandWithReply(1);
            data.AddRange(new byte[]
            {
                OpCode.InputRead,
                daisyChainLayer,
                sensorPort,
                SensorType.NXTLight,
                1,
                ParameterType.Variable | VariableScope.Global,
            });
        }
    }
}
