using Mindstorms.Core.Enums;
using System.Collections.Generic;

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

            dataList.AddRange(Constants.DefaultEncoding.GetBytes(fullPathDirectoryName));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
