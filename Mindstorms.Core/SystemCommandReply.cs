using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core
{
    public class SystemCommandReply : CommandReplyBase
    {
        public const byte ContinueSystemCommandResponseHeaderLength = 8;

        public const byte SystemCommandResponseHeaderLength = 10;

        public SystemCommand SystemCommand { get; }

        public uint ListSize { get; }

        public byte Handle { get; }

        public SystemCommandReply(byte[] rawResponseData) : base(rawResponseData)
        {
            SystemCommand = (SystemCommand)rawResponseData[3];

            try
            {
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
            catch { }
        }
    }
}
