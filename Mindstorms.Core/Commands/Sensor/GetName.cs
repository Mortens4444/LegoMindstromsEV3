using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Sensor
{
    public class GetName : Command
    {
        public GetName(byte sensorPort, DaisyChainLayer daisyChainLayer)
        {
            data = GetDirectCommandWithReply(Constants.DefaultStringLength);
            data.AddRange(new byte[]
            {
                OpCode.InputDevice,
                InputSubCode.GetName,
                daisyChainLayer,
                sensorPort,
                Constants.DefaultStringLength,
                ParameterType.Variable | VariableScope.Global
            });
        }
    }
}