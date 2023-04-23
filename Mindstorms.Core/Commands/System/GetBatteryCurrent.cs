using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System;

public class GetBatteryCurrent : Command
{
    public GetBatteryCurrent()
    {
        data = GetDirectCommandWithReply(4);
        data.AddRange(new byte[]
        {
            OpCode.UIRead,
            SystemInfoSubCommand.GetBatteryCurrent,
            ParameterType.Variable | VariableScope.Global
        });
    }
}
