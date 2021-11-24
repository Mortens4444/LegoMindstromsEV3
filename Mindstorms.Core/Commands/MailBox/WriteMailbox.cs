using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mindstorms.Core.Commands.File
{
    public class WriteMailboxCommand : Command
    {
#warning This command must be tested.
        public WriteMailboxCommand(string name, string message)
        {
            var dataList = new List<byte>
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.WriteMailbox,
                (byte)name.Length,
            };

            dataList.AddRange(Encoding.ASCII.GetBytes(name));
            dataList.Add(0);

            var messageLength = BitConverter.GetBytes((ushort)message.Length);
            dataList.Add(messageLength[0]);
            dataList.Add(messageLength[1]);

            dataList.AddRange(Encoding.ASCII.GetBytes(message));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
