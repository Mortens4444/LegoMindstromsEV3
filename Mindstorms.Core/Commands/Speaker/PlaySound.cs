using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.Speaker
{
    public class PlaySound : Command
    {
        public PlaySound(string filePath)
            : this(Constants.DefaultVolume, filePath)
        { }

        /// <summary>
        /// Plays a sound file from the brick.
        /// </summary>
        /// <param name="volume">Volume to be used.</param>
        /// <param name="filePath">Full file path without the .rsf extension.</param>
        public PlaySound(byte volume, string filePath)
        {
            data = DirectCommandNoReply;
            data.Add(OpCode.Sound);
            data.Add(SoundSubCode.Play);
            data.AppendOneBytesParameter(volume);
            data.AppendStringParameter(RemoveExtension(filePath));
        }

        private static string RemoveExtension(string filePath, string extension = Constants.SoundFileExtension)
        {
            if (filePath.EndsWith(extension))
            {
                filePath = filePath.Substring(0, filePath.Length - extension.Length);
            }

            return filePath;
        }
    }
}
