using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.File
{
    public class GetFile : Command
    {
#warning This command must be tested.
        public GetFile(string filePath)
        {
            var maxBytesInReply = BitConverter.GetBytes(Constants.ChunkSize);

            var dataList = new List<byte>
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.BeginGetFile,
                maxBytesInReply[0],
                maxBytesInReply[1]
            };
            dataList.AddRange(Constants.DefaultEncoding.GetBytes(filePath));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
