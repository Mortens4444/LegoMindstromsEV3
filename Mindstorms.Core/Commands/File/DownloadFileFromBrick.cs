using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.File
{
#warning May not work for big files.
    public class DownloadFileFromBrick : Command
    {
        public const ushort MaxChunkSize = 65534;

        public DownloadFileFromBrick(string filePath)
        {
            var maxBytesInReply = BitConverter.GetBytes(MaxChunkSize);

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
