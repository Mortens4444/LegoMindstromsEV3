using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Sensor
{
    public class GetName : Command
    {
        public GetName(byte sensorPort)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                0x3F,
                0,
                (byte)OpCode.InputDevice,
                (byte)InputSubCode.GetName,
                (byte)DaisyChainLayer.EV3,
                sensorPort,
                0x3F,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}