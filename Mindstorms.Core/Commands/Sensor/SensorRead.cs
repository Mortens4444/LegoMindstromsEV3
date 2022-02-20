using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Sensor
{
    public abstract class SensorRead : Command
    {
        protected byte[] GetData(byte sensorPort, byte sensorType, byte sensorMode, InputSubCode inputSubCode)
        {
            return new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                4,
                0,
                (byte)OpCode.InputDevice,
                (byte)inputSubCode,
                (byte)DaisyChainLayer.EV3,
                sensorPort,
                sensorType,
                sensorMode,
                1,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}