using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;
using Mindstorms.Core.Music;

namespace Mindstorms.Core.Commands.Speaker
{
    public class Beep : AwaitableCommand
    {
        public static byte DefaultVolume = 10;

        public static ushort DefaultNoteDurationMs = 500;

        public Beep(Note note)
            : this(DefaultVolume, note, DefaultNoteDurationMs)
        { }

        public Beep(Note note, ushort durationMs)
            : this(DefaultVolume, note, durationMs)
        { }

        public Beep(byte volume, ushort frequency, ushort durationMs)
            : base(durationMs)
        {
            data = DirectCommandNoReply;
            data.Add(OpCode.Sound);
            data.Add(SoundSubCode.Tone);
            data.AppendOneBytesParameter(volume);
            data.AppendTwoBytesParameter(frequency);
            data.AppendTwoBytesParameter(durationMs);
        }
    }
}
