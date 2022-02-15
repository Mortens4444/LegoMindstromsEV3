using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.File
{
    public class ListFiles : Command
    {
        public const ushort MaxListSize = 1014;

        /// <summary>
        /// https://www.lego.com/cdn/cs/set/assets/blt6879b00ae6951482/LEGO_MINDSTORMS_EV3_Communication_Developer_Kit.pdf
        /// If it is a file: 32 chars(hex) of MD5SUM + space + 8 chars(hex) of filesize + space + filename + new line
        /// If it is a folder: foldername + / + new line
        /// </summary>
        /// <param name="path"></param>
        //TODO: Fix ListFilesCommand
#warning Fix folder listing
        public ListFiles(string path)
        {
            var maxBytesInFileList = BitConverter.GetBytes(MaxListSize);

            var dataList = new List<byte>
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.ListFiles,
                maxBytesInFileList[0],
                maxBytesInFileList[1]
            };
            dataList.AddRange(Constants.DefaultEncoding.GetBytes(path));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
