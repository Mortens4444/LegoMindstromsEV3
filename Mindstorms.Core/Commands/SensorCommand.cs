using Mindstorms.Core.Enums;

namespace Mindstorms.Core
{
    public abstract class SensorCommand : Command
    {
        protected byte[] GetData(byte sensorPort, byte sensorType, byte sensorMode)
        {
            return new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                4,
                0,
                (byte)OpCode.InputDevice,
                (byte)InputSubCode.ReadySI,
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