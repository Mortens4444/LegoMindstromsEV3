using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Speaker
{
    public class Silence : Command
    {
        public Silence()
        {
            data = DirectCommandNoReply;
            data.Add((byte)OpCode.Sound);
            data.Add((byte)SoundSubCode.Break);
        }
    }
}
