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
            data.Add((byte)OpCode.System);
            data.AppendStringParameter(command);
            data.Add((byte)ParameterType.Variable | (byte)VariableScope.Local);
            data.Add((byte)OpCode.Move8_8);
            data.Add(1 | (byte)ParameterType.Variable | (byte)VariableScope.Local);
            data.Add((byte)ParameterType.Variable | (byte)VariableScope.Global);
        }
    }
}
