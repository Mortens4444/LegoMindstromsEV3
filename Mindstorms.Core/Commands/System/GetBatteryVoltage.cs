using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System;

public class GetBatteryVoltage : Command
{
    public GetBatteryVoltage()
    {
        data = GetDirectCommandWithReply(4);
        data.AddRange(new byte[]
        {
            OpCode.UIRead,
            SystemInfoSubCommand.GetBatteryVoltage,
            ParameterType.Variable | VariableScope.Global
        });
    }
}
