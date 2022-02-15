using Mindstorms.Core.Enums;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.File
{
    public class CloseFileHandle : Command
    {
#warning This command must be tested.
        public CloseFileHandle(byte fileHandle, string hash)
        {
            var dataList = new List<byte>
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.CloseFileHandle,
                fileHandle
            };

            dataList.AddRange(Constants.DefaultEncoding.GetBytes(hash));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
