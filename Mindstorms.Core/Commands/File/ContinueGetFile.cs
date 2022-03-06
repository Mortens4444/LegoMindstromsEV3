using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core.Commands.File
{
    public class ContinueGetFile : Command
    {
#warning This command must be tested.
        public ContinueGetFile(byte fileHandle)
        {
            var maxBytesInReply = BitConverter.GetBytes(Constants.ChunkSize);

            data = new byte[]
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.ContinueGetFile,
                fileHandle,
                maxBytesInReply[0],
                maxBytesInReply[1]
            };
        }
    }
}
