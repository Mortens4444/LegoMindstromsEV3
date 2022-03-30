using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class ResetMotor : Command
    {
#warning This command must be tested.

        public ResetMotor(DaisyChainLayer daisyChainLayer, OutputPort outputPort)
        {
            data = DirectCommandNoReply;
            data.AddRange(new byte[]
            {
                OpCode.OutputReset,
                daisyChainLayer,
                outputPort
            });
        }
    }
}
