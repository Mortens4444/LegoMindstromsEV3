using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mindstorms.Core.Commands.File
{
    public class DownloadFile : Command
    {
        public const ushort MaxChunkSize = 65534;

        //TODO: Fix DownloadFileCommand
#warning File download result arrives into the listView after a List command is executed.
        public DownloadFile(string filePath)
        {
            var maxBytesInReply = BitConverter.GetBytes(MaxChunkSize);

            var dataList = new List<byte>
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.BeginFileUpload,
                maxBytesInReply[0],
                maxBytesInReply[1]
            };
            dataList.AddRange(Encoding.ASCII.GetBytes(filePath));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
