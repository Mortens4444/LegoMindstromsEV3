using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.Program
{
    public class SystemCall : Command
    {
        public SystemCall(string command)
        {
            data = GetDirectCommandWithReply(4);
            data.Add(OpCode.System);
            data.AppendStringParameter(command);
            data.Add(ParameterType.Variable | VariableScope.Global);
        }
    }
}
