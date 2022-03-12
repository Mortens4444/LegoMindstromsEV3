using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.System
{
    public class SetPin : Command
    {
#warning This command must be tested.
        public SetPin(CommunicationInterface communicationInterface, string brickName, string pinCode)
        {
            data = new List<byte>
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0x0C,

                (byte)OpCode.ComSet,
                (byte)ComSetSubCommand.SetPin,

                (byte)communicationInterface
            };
            //data.AppendOneBytesParameter((byte)communicationInterface);
            data.AppendStringParameter(brickName);
            data.AppendStringParameter(pinCode);
        }
    }
}
