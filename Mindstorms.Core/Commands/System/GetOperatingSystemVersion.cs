using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System;

public class GetOperatingSystemVersion : Command
{
    public GetOperatingSystemVersion()
    {
        data = GetDirectCommandWithReply(Constants.DefaultResponseLength);
        data.AddRange(new byte[]
        {
            OpCode.UIRead,
            SystemInfoSubCommand.GetOperatingSystemVersion,
            Constants.DefaultResponseLength,
            ParameterType.Variable | VariableScope.Global
        });
    }
}
