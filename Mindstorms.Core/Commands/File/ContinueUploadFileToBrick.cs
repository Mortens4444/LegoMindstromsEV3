using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindstorms.Core.Commands.File
{
    public class ContinueUploadFileToBrick : Command
    {
#warning May not work for big files.
        public ContinueUploadFileToBrick(byte fileHandle, IEnumerable<byte> fileContent)
        {
            var bytesToSend = BitConverter.GetBytes(fileContent.Count());

            var dataList = new List<byte>
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.ContinueFileDownload,
                fileHandle,
                bytesToSend[0],
                bytesToSend[1],
                bytesToSend[2],
                bytesToSend[3]
            };
            dataList.AddRange(fileContent);
            data = dataList.ToArray();
        }
    }
}
