using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetBatteryTemperatureRise : Command
    {
#warning This command must be tested.
        public GetBatteryTemperatureRise()
        {
            data = GetDirectCommandWithReply(4);
            data.AddRange(new byte[]
            {
                OpCode.UIRead,
                SystemInfoSubCommand.GetBatteryTemperatureRise,
                ParameterType.Variable | VariableScope.Global
            });
        }
    }
}
