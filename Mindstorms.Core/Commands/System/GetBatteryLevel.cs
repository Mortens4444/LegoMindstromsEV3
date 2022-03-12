using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetBatteryLevel : Command
    {
        public GetBatteryLevel()
        {
            data = GetDirectCommandWithReply(1);
            data.AddRange(new byte[]
            {
                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetBatteryLevel,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            });
        }
    }
}
