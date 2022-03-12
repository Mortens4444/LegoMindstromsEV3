using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetBatteryVoltage : Command
    {
        public GetBatteryVoltage()
        {
            data = GetDirectCommandWithReply(4);
            data.AddRange(new byte[]
            {
                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetBatteryVoltage,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            });
        }
    }
}
