using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mindstorms.Core.Commands.File
{
    public class ContinueListFiles : Command
    {
        /// <summary>
        /// https://www.lego.com/cdn/cs/set/assets/blt6879b00ae6951482/LEGO_MINDSTORMS_EV3_Communication_Developer_Kit.pdf
        /// If it is a file: 32 chars(hex) of MD5SUM + space + 8 chars(hex) of filesize + space + filename + new line
        /// If it is a folder: foldername + / + new line
        /// </summary>
        /// <param name="path"></param>
        //TODO: Fix ListFilesCommand
#warning Listing long folders should use CONTINUE_LISTING
        public ContinueListFiles(byte handle)
        {
            var maxBytesInFileList = BitConverter.GetBytes(ListFiles.MaxListSize);

            data = new byte[]
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.ContinueListFiles,
                handle,
                maxBytesInFileList[0],
                maxBytesInFileList[1]
            };
        }
    }
}
