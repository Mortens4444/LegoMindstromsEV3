using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core.Commands.File
{
    public class ContinueUploadFileToBrick : Command
    {
#warning May not work for big files.
        public ContinueUploadFileToBrick(byte fileHandle)
        {
            var maxBytesInReply = BitConverter.GetBytes(DownloadFileFromBrick.MaxChunkSize);

            data = new byte[]
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.ContinueFileDownload,
                fileHandle,
                maxBytesInReply[0],
                maxBytesInReply[1]
            };
        }
    }
}
