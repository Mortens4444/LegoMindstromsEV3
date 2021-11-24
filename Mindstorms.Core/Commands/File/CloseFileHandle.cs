using Mindstorms.Core.Enums;
using System.Collections.Generic;
using System.Text;

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

            dataList.AddRange(Encoding.ASCII.GetBytes(hash));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
