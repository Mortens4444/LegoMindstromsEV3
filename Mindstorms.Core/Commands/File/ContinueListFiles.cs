using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.File
{
    public class ContinueListFiles : Command
    {
        /// <summary>
        /// https://www.lego.com/cdn/cs/set/assets/blt6879b00ae6951482/LEGO_MINDSTORMS_EV3_Communication_Developer_Kit.pdf
        /// If it is a file: 32 chars(hex) of MD5SUM + space + 8 chars(hex) of filesize + space + filename + new line
        /// If it is a folder: foldername + / + new line
        /// </summary>
        /// <param name="path"></param>
        public ContinueListFiles(byte handle)
        {
            data = SystemCommandWithReply;
            data.Add((byte)SystemCommand.ContinueListFiles);
            data.Add(handle);
            data.Append(Constants.ChunkSize);
        }
    }
}
