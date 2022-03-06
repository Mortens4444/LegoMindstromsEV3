using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.File
{
    public class UploadFileToBrick : Command
    {
        public UploadFileToBrick(string destinationFilePath, int fileSize)
        {
            var bytesToSend = BitConverter.GetBytes(fileSize);

            var dataList = new List<byte>
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.BeginFileDownload,
                bytesToSend[0],
                bytesToSend[1],
                bytesToSend[2],
                bytesToSend[3]
            };
            dataList.AddRange(Constants.DefaultEncoding.GetBytes(destinationFilePath));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
