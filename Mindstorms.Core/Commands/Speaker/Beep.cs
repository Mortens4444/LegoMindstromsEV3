using Mindstorms.Core.Enums;
using Mindstorms.Core.Music;
using System;

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
            var frequencyBytes = BitConverter.GetBytes(frequency);
            var durationMsBytes =  BitConverter.GetBytes(durationMs);

            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,
                (byte)OpCode.Sound,
                (byte)SoundSubCode.Tone,

                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                volume,

                (byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                frequencyBytes[0],
                frequencyBytes[1],

                (byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                durationMsBytes[0],
                durationMsBytes[1]
            };
        }
    }
}
