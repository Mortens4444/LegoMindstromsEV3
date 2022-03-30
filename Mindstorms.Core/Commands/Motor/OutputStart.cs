using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class OutputStart : Command
    {
        public OutputStart(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
        {
            data = DirectCommandNoReply;
            data.AddRange(new byte[]
            {
                OpCode.OutputStart,
                daisyChainLayer,
                outputPort
            });
        }
    }
}
