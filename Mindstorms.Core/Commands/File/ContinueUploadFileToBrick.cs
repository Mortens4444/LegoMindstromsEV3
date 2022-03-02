using Mindstorms.Core.Enums;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.File
{
    public class ContinueUploadFileToBrick : Command
    {
        public ContinueUploadFileToBrick(byte fileHandle, IEnumerable<byte> fileContent)
        {
            var dataList = new List<byte>
            {
                (byte)CommandType.SystemCommand | (byte)Response.NotExpected,
                (byte)SystemCommand.ContinueFileDownload,
                fileHandle
            };
            dataList.AddRange(fileContent);
            data = dataList.ToArray();
        }
    }
}
