using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core.Commands.File
{
    public class ContinueDownloadFile : Command
    {
        //TODO: Fix DownloadFileCommand
#warning File download result arrives into the listView after a List command is executed.
        public ContinueDownloadFile(byte fileHandle)
        {
            var maxBytesInReply = BitConverter.GetBytes(DownloadFile.MaxChunkSize);

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
