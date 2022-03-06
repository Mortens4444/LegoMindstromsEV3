using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core.Commands.File
{
    public class ContinueDownloadFileFromBrick : Command
    {
        public ContinueDownloadFileFromBrick(byte fileHandle)
        {
            var maxBytesInReply = BitConverter.GetBytes(Constants.ChunkSize);

            data = new byte[]
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.ContinueFileUpload,
                fileHandle,
                maxBytesInReply[0],
                maxBytesInReply[1]
            };
        }
    }
}
