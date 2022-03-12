using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetBatteryCurrent : Command
    {
        public GetBatteryCurrent()
        {
            data = GetDirectCommandWithReply(4);
            data.AddRange(new byte[]
            {
                (byte)OpCode.UIRead,
                (byte)SystemInfoSubCommand.GetBatteryCurrent,
                (byte)ParameterType.Variable | (byte)VariableScope.Global
            });
        }
    }
}
