using Mindstorms.Core.Enums;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.Sensor
{
    public abstract class SensorRead : Command
    {
        protected List<byte> GetData(byte sensorPort, byte sensorType, byte sensorMode, InputSubCode inputSubCode, DaisyChainLayer daisyChainLayer)
        {
            return new List<byte>
            {
                DirectCommandWithReply,
                4,
                0,
                OpCode.InputDevice,
                inputSubCode,
                daisyChainLayer,
                sensorPort,
                sensorType,
                sensorMode,
                1,
                ParameterType.Variable | VariableScope.Global
            };
        }
    }
}