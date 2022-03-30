using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class ChangeMotorPolarity : Command
    {
#warning This command must be tested.

        public ChangeMotorPolarity(DaisyChainLayer daisyChainLayer, OutputPort outputPort, Polarity polarity)
        {
            data = DirectCommandNoReply;
            data.AddRange(new byte[]
            {
                OpCode.OutputPolarity,
                daisyChainLayer,
                outputPort,
                polarity
            });
        }
    }
}
