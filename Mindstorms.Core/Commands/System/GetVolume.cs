using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.System
{
    public class GetVolume : Command
    {
        public GetVolume()
        {
            data = GetDirectCommandWithReply(1);
            data.AddRange(new byte[]
            {
                OpCode.Info,
                InfoSubCode.GetVolume,
                ParameterType.Variable | VariableScope.Global
            });
        }
    }
}
