using Mindstorms.Core.Enums;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.System
{
    public class SetPin : Command
    {
#warning This command must be tested.
        public SetPin(CommunicationInterface communicationInterface, string brickName, string pinCode)
        {
            var dataList = new List<byte>
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0x0C,

                (byte)OpCode.ComSet,
                (byte)ComSetSubCommand.SetPin,

                //(byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                (byte)communicationInterface,
                (byte)ParameterFormat.Long | (byte)FollowType.TerminatedString2
            };
            dataList.AddRange(Constants.DefaultEncoding.GetBytes(brickName));
            dataList.Add(0);

            dataList.Add((byte)ParameterFormat.Long | (byte)FollowType.TerminatedString2);
            dataList.AddRange(Constants.DefaultEncoding.GetBytes(pinCode));
            dataList.Add(0);

            data = dataList.ToArray();
        }
    }
}
