using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core.Commands.Object
{
    /// <summary>
    /// This function can be used for starting a specific object to execute.
    /// </summary>
    public class Start : Command
    {
#warning This command must be tested.
        public Start(ushort objectId)
        {
            var objectIdBytes = BitConverter.GetBytes(objectId);

            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.ObjectStart,
                (byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                objectIdBytes[0],
                objectIdBytes[1]
            };
        }
    }
}
