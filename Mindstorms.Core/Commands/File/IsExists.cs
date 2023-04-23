using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.File;

public class IsExists : Command
{
    public IsExists(string filePath)
    {
        data = GetDirectCommandWithReply(1);
        data.Add(OpCode.FileName);
        data.Add(FilenameSubCode.Exist);
        data.AppendStringParameter(filePath);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }
}
