using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Error;

public class GetError : Command
{
    public GetError()
    {
        data = GetDirectCommandWithReply(1);
        data.Add(OpCode.Info);
        data.Add(InfoSubCode.GetError);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }
}
