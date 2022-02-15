using Mindstorms.Core.Enums;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.Speaker
{
    public class PlaySound : Command
    {
        public static byte DefaultVolume = 20;

        public PlaySound(string filePath)
            : this(DefaultVolume, filePath)
        { }

        /// <summary>
        /// Plays a sound file from the brick.
        /// </summary>
        /// <param name="volume">Volume to be used.</param>
        /// <param name="filePath">Full file path without the .rsf extension.</param>
        public PlaySound(byte volume, string filePath)
        {
            var dataList = new List<byte>
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.Sound,
                (byte)SoundSubCode.Play,

                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                volume,

                (byte)ParameterFormat.Long | (byte)FollowType.TerminatedString2
            };
            if (filePath.EndsWith(".rsf"))
            {
                filePath = filePath.Substring(0, filePath.Length - 4);
            }

            dataList.AddRange(Constants.DefaultEncoding.GetBytes(filePath));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
