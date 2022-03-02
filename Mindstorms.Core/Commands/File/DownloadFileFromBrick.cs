using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.File
{
    public class DownloadFileFromBrick : Command
    {
        public const ushort MaxChunkSize = 900;

        public DownloadFileFromBrick(string filePath, int fileSize)
        {
            var bytesToRead = Math.Min(fileSize, MaxChunkSize);
            var maxBytesInReply = BitConverter.GetBytes(bytesToRead);

            var dataList = new List<byte>
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.BeginFileUpload,
                maxBytesInReply[0],
                maxBytesInReply[1]
            };
            dataList.AddRange(Constants.DefaultEncoding.GetBytes(filePath));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
