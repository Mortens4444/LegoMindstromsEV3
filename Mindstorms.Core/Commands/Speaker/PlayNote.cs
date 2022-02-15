using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.Speaker
{
    /// <summary>
    /// C4 - G#6
    /// </summary>
    public class PlayNote : AwaitableCommand
    {
        public static byte DefaultVolume = 10;

        public static ushort DefaultNoteDurationMs = 500;

        public PlayNote(string note)
            : this(DefaultVolume, note, DefaultNoteDurationMs)
        { }

        public PlayNote(string note, ushort durationMs)
            : this(DefaultVolume, note, durationMs)
        { }

        public PlayNote(byte volume, string note, ushort durationMs)
            : base(durationMs)
        {
            var durationMsBytes =  BitConverter.GetBytes(durationMs);

            var dataList = new List<byte>
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                8,
                (byte)OpCode.NoteToFrequency,
                (byte)ParameterFormat.Long | (byte)FollowType.TerminatedString2,
            };
            dataList.AddRange(Constants.DefaultEncoding.GetBytes(note));
            dataList.Add(0);
            dataList.AddRange(new byte[] {
                (byte)ParameterType.Variable | (byte)VariableScope.Local,
                (byte)OpCode.Sound,
                (byte)SoundSubCode.Tone,
                volume,
                (byte)ParameterType.Variable | (byte)VariableScope.Local,
                (byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                durationMsBytes[0],
                durationMsBytes[1]
            });

            data = dataList.ToArray();
        }
    }
}
