using Mindstorms.Core.Enums;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.File
{
    public class DeleteFile : Command
    {
        public DeleteFile(string fullPathFileName)
        {
            var dataList = new List<byte>
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.DeleteFile
            };

            dataList.AddRange(Constants.DefaultEncoding.GetBytes(fullPathFileName));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
