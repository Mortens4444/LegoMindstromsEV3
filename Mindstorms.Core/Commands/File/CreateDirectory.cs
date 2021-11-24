using Mindstorms.Core.Enums;
using System.Collections.Generic;
using System.Text;

namespace Mindstorms.Core.Commands.File
{
    public class CreateDirectory : Command
    {
        public CreateDirectory(string fullPathDirectoryName)
        {
            var dataList = new List<byte>
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.CreateDir,
            };

            dataList.AddRange(Encoding.ASCII.GetBytes(fullPathDirectoryName));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
