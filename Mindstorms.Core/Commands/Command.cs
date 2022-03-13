using Mindstorms.Core.Enums;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands
{
    public abstract class Command
	{
        protected List<byte> data;

        public byte[] Data
		{
            get { return data.ToArray(); }
        }

        protected readonly List<byte> SystemCommandNoReply = new List<byte> { CommandType.SystemCommand | Response.NotExpected };

        protected readonly List<byte> SystemCommandWithReply = new List<byte> { CommandType.SystemCommand | Response.Required };

        protected readonly List<byte> DirectCommandNoReply = new List<byte> { CommandType.DirectCommand | Response.NotExpected, 0, 0 };

        protected readonly byte DirectCommandWithReply = CommandType.DirectCommand | Response.Required;

        protected List<byte> GetDirectCommandWithReply(byte numberOfExpectedBytes, byte localBytes = 0) => new List<byte> { DirectCommandWithReply, numberOfExpectedBytes, (byte)(localBytes << 2) };
    }
}
