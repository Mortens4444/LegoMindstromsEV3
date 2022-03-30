using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class GetTachoCount : Command
    {
#warning This command must be tested.

        public GetTachoCount(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
        {
            data = GetDirectCommandWithReply(4);
            data.AddRange(new byte[]
            {
                OpCode.OutputGetCount,
                daisyChainLayer,
                outputPort,
                ParameterType.Variable | VariableScope.Global
            });
        }
    }
}
