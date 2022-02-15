using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core.Commands.Object
{
    /// <summary>
    /// This function will make the specific execution wait until the specific object have finalized.
    /// </summary>
    public class Wait : Command
    {
#warning This command must be tested.
        public Wait(ushort objectId)
        {
            var objectIdBytes = BitConverter.GetBytes(objectId);

            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.ObjectWait,
                (byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                objectIdBytes[0],
                objectIdBytes[1]
            };
        }
    }
}
