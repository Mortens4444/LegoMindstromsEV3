using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System;

public class GetBatteryLevel : Command
{
    public GetBatteryLevel()
    {
        data = GetDirectCommandWithReply(1);
        data.AddRange(new byte[]
        {
            OpCode.UIRead,
            SystemInfoSubCommand.GetBatteryLevel,
            ParameterType.Variable | VariableScope.Global
        });
    }
}
