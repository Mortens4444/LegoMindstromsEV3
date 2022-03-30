using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class ProgramStop : Command
    {
#warning This command must be tested.

        public ProgramStop()
        {
            data = DirectCommandNoReply;
            data.Add(OpCode.OutputPrgStop);
        }
    }
}
