using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.Program
{
    public class SystemCall : Command
    {
#warning This command must be tested.
        public SystemCall(string command)
        {
            data = GetDirectCommandWithReply(1, 4);
            data.Add(OpCode.System);
            data.AppendStringParameter(command);
            data.Add(ParameterType.Variable | VariableScope.Local);
            data.Add(OpCode.Move8_8);
            data.Add(1 | ParameterType.Variable | VariableScope.Local);
            data.Add(ParameterType.Variable | VariableScope.Global);
        }
    }
}
