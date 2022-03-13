using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Speaker
{
    public class Silence : Command
    {
        public Silence()
        {
            data = DirectCommandNoReply;
            data.Add(OpCode.Sound);
            data.Add(SoundSubCode.Break);
        }
    }
}
