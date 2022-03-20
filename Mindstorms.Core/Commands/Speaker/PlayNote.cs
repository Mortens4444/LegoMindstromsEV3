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
        public PlayNote(string note, byte volume)
            : this(volume, note, Constants.DefaultNoteDurationMs)
        { }

        public PlayNote(string note, ushort durationMs, byte volume)
            : this(volume, note, durationMs)
        { }

        public PlayNote(byte volume, string note)
            : this(volume, note, Constants.DefaultNoteDurationMs)
        { }

        public PlayNote(byte volume, string note, ushort durationMs)
            : base(durationMs)
        {
            data = new List<byte>
            {
                CommandType.DirectCommand | Response.NotExpected,
                0,
                8,
                OpCode.NoteToFrequency,
            };
            data.AppendStringParameter(note);
            data.AddRange(new byte[] {
                ParameterType.Variable | VariableScope.Local,
                OpCode.Sound,
                SoundSubCode.Tone,
                volume,
                ParameterType.Variable | VariableScope.Local
            });
            data.AppendTwoBytesParameter(durationMs);
        }
    }
}
