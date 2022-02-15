using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core.Commands.Object
{
    /// <summary>
    /// This function trigger the specific object and initaite execution if alle trigger requirements are active.
    /// </summary>
    public class Trigger : Command
    {
#warning This command must be tested.
        public Trigger(ushort objectId)
        {
            var objectIdBytes = BitConverter.GetBytes(objectId);

            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.ObjectTrigger,
                (byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                objectIdBytes[0],
                objectIdBytes[1]
            };
        }
    }
}
