using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.File
{
#warning This command must be tested.
    public class WriteBytesToFile : Command
    {
        public const ushort MaxChunkSize = 65534;

        public WriteBytesToFile(byte handle, byte[] bytes)
        {
            var maxBytesInReply = BitConverter.GetBytes(MaxChunkSize);

            var dataList = new List<byte>
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.File,
                (byte)FileSubCode.WriteBytes,
                handle,
                (byte)bytes.Length,

            };
            dataList.AddRange(bytes);
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
