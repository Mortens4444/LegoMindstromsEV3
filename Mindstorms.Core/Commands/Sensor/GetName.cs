using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Sensor
{
    public class GetName : Command
    {
        public GetName(byte sensorPort, DaisyChainLayer daisyChainLayer)
        {
            data = GetDirectCommandWithReply(0x3F);
            data.AddRange(new byte[]
            {
                (byte)OpCode.InputDevice,
                (byte)InputSubCode.GetName,
                (byte)daisyChainLayer,
                sensorPort,
                0x3F,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            });
        }
    }
}