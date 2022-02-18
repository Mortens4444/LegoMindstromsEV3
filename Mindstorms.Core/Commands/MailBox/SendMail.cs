using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.MailBox
{
    public class SendMail : Command
    {
#warning This command must be tested.
        public SendMail(string name, string message)
        {
            var dataList = new List<byte>
            {
                (byte)CommandType.SystemCommand | (byte)Response.NotExpected,
                (byte)SystemCommand.WriteMailbox,
                (byte)name.Length,
            };

            dataList.AddRange(Constants.DefaultEncoding.GetBytes(name));
            dataList.Add(0);

            var messageLength = BitConverter.GetBytes((ushort)message.Length);
            dataList.Add(messageLength[0]);
            dataList.Add(messageLength[1]);

            dataList.AddRange(Constants.DefaultEncoding.GetBytes(message));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
