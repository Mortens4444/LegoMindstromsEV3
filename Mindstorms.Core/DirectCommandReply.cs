using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core
{
    /// <summary>
    /// 
    /// Byte 0 – 1: Reply size, Little Endian. Reply size not including these 2 bytes
    /// 
    /// Byte 2 – 3: Message counter, Little Endian.Equals the Direct Command
    /// Byte 4: Reply type.See defines above
    /// Byte 5 - n: Resonse buffer. I.e.the content of the by the Command reserved global variables. I.e.
    /// if the command reserved 64 bytes, these bytes will be placed in the reply packet as the
    /// bytes 5 to 68.
    /// 
    /// </summary>
    public class DirectCommandReply : ICommandReply
    {
        public const byte ResponseHeaderLength = 5;

        public ushort MessageCounter { get; }

        public CommandType TypeOfMessage { get; }

        public CommandReplyStatus CommandReplyStatus { get; }

        public byte[] RawResponseData { get; }

        public DirectCommandReply(byte[] rawResponseData)
        {
            RawResponseData = rawResponseData;
            MessageCounter = BitConverter.ToUInt16(rawResponseData, 0);
            TypeOfMessage = (CommandType)rawResponseData[2];

            CommandReplyStatus = rawResponseData.Length > 4 ? (CommandReplyStatus)(rawResponseData[4]) : CommandReplyStatus.NoErrorFlagIsPresent;
        }
    }
}
