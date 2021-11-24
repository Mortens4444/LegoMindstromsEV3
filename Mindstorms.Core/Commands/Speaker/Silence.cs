using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Speaker
{
    public class Silence : Command
    {
        public Silence()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,
                (byte)OpCode.Sound,
                (byte)SoundSubCode.Break
            };
        }
    }
}
