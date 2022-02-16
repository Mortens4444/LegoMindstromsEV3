﻿using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindstorms.Core.Commands.File
{
    public class UploadFileToBrick : Command
    {
        public const ushort MaxChunkSize = 65534;

        public UploadFileToBrick(string destinationFilePath, IEnumerable<byte> fileContent)
        {
            var bytesToSend = BitConverter.GetBytes(fileContent.Count());

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
            dataList.AddRange(fileContent);

            data = dataList.ToArray();
        }
    }
}
