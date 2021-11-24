using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class GetSensorType : Command
    {
        public GetSensorType(SensorPort sensorPort)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                2,
                0,
                (byte)OpCode.InputDevice,
                (byte)InputSubCode.GetTypeMode,
                (byte)DaisyChainLayer.EV3,
                (byte)sensorPort,
                2,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
