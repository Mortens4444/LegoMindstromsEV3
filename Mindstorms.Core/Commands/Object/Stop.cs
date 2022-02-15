using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core.Commands.Object
{
    /// <summary>
    /// This function can be used for stopping a specific object in further execution.
    /// </summary>
    public class Stop : Command
    {
#warning This command must be tested.
        public Stop(ushort objectId)
        {
            var objectIdBytes = BitConverter.GetBytes(objectId);

            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.ObjectStop,
                (byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                objectIdBytes[0],
                objectIdBytes[1]
            };
        }
    }
}
