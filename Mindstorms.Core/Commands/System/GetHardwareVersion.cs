using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System;

public class GetHardwareVersion : Command
{
    public GetHardwareVersion()
    {
        data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
        data.AddRange(new byte[]
        {
            OpCode.UIRead,
            SystemInfoSubCommand.GetHardwareVersion,
            Constants.DefaultResponseLength,
            ParameterType.Variable | VariableScope.Global
        });
    }
}
