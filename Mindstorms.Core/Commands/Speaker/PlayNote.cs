using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.Speaker
{
    /// <summary>
    /// C4 - G#6
    /// </summary>
    public class PlayNote : AwaitableCommand
    {
        public PlayNote(string note)
            : this(Constants.DefaultVolume, note, Constants.DefaultNoteDurationMs)
        { }

        public PlayNote(string note, ushort durationMs)
            : this(Constants.DefaultVolume, note, durationMs)
        { }

        public PlayNote(byte volume, string note)
            : this(volume, note, Constants.DefaultNoteDurationMs)
        { }

        public PlayNote(byte volume, string note, ushort durationMs)
            : base(durationMs)
        {
            data = new List<byte>
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                8,
                (byte)OpCode.NoteToFrequency,
            };
            data.AppendStringParameter(note);
            data.AddRange(new byte[] {
                (byte)ParameterType.Variable | (byte)VariableScope.Local,
                (byte)OpCode.Sound,
                (byte)SoundSubCode.Tone,
                volume,
                (byte)ParameterType.Variable | (byte)VariableScope.Local
            });
            data.AppendTwoBytesParameter(durationMs);
        }
    }
}
