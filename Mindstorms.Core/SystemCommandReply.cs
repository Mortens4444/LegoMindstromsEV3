using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core
{
    public class SystemCommandReply : ICommandReply
    {
        public const byte ContinueSystemCommandResponseHeaderLength = 8;

        public const byte SystemCommandResponseHeaderLength = 10;

        public ushort MessageCounter { get; }

        public CommandType TypeOfMessage { get; }

        public SystemCommand SystemCommand { get; }

        public CommandReplyStatus CommandReplyStatus { get; }

        public uint ListSize { get; }

        public byte Handle { get; }

        public byte[] RawResponseData { get; }

        public SystemCommandReply(byte[] rawResponseData)
        {
            RawResponseData = rawResponseData;
            if (RawResponseData.Length < ContinueSystemCommandResponseHeaderLength)
            {
                throw new ArgumentException($"Raw response data must be at least {ContinueSystemCommandResponseHeaderLength} bytes", nameof(rawResponseData));
            }            

            MessageCounter = BitConverter.ToUInt16(rawResponseData, 0);

            TypeOfMessage = (CommandType)rawResponseData[2];
            SystemCommand = (SystemCommand)rawResponseData[3];

            CommandReplyStatus = (CommandReplyStatus)(rawResponseData[4]);

            if (rawResponseData.Length != ContinueSystemCommandResponseHeaderLength)
            {
                ListSize = BitConverter.ToUInt32(rawResponseData, 5);
                Handle = rawResponseData[9];
            }
            else
            {
                Handle = rawResponseData[5];
            }
        }
    }
}
