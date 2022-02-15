using Mindstorms.Core.Enums;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.System
{
    public class SetBrickName : Command
    {
        public SetBrickName(string brickName)
        {
            var dataList = new List<byte>
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.ComSet,
                (byte)ComSetSubCommand.SetBrickName,
                (byte)ParameterFormat.Long | (byte)FollowType.TerminatedString2
            };
            dataList.AddRange(Constants.DefaultEncoding.GetBytes(brickName));
            dataList.Add(0);
            
            data = dataList.ToArray();
        }
    }
}
