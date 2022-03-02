using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;

namespace Mindstorms.Core
{
    public class SystemCommandReply : CommandReplyBase
    {
        private readonly List<SystemCommand> CommandsWithLength = new List<SystemCommand> { SystemCommand.BeginFileUpload, SystemCommand.BeginGetFile, SystemCommand.ContinueGetFile, SystemCommand.ListFiles };
        private readonly List<SystemCommand> CommandsWithoutHandle = new List<SystemCommand> { SystemCommand.CloseFileHandle, SystemCommand.CreateDir, SystemCommand.DeleteFile, SystemCommand.ListOpenHandles, SystemCommand.BluetoothPin };

        public const byte ContinueSystemCommandResponseHeaderLength = 6;

        public const byte SystemCommandResponseHeaderLength = 10;

        public SystemCommand SystemCommand { get; }

        public uint Length { get; }

        public byte Handle { get; }

        public SystemCommandReply(byte[] rawResponseData) : base(rawResponseData)
        {
            SystemCommand = (SystemCommand)rawResponseData[3];

            if (CommandsWithLength.Contains(SystemCommand))
            {
                Length = BitConverter.ToUInt32(rawResponseData, 5);
                Handle = rawResponseData[9];
            }
            else
            {
                if (!CommandsWithoutHandle.Contains(SystemCommand))
                {
                    Handle = rawResponseData[5];
                }
            }
        }
    }
}
