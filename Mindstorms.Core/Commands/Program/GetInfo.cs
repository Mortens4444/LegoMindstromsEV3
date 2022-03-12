using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.Program
{
#warning This command must be tested.
    public class GetInfo : Command
    {
        public GetInfo(ushort programSlotId)
        {
            data = GetDirectCommandWithReply(1);
            data.Add((byte)OpCode.ProgramInfo);
            data.Append(programSlotId);
            data.Add((byte)ParameterType.Variable | (byte)VariableScope.Global);
        }
    }
}
