using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core.Commands.Motor
{
    public class SetLargeMotorSpeed : Command
    {
        public SetLargeMotorSpeed(SetMotorSpeedParams motorSpeedChange)
        {
            var speedBytes = BitConverter.GetBytes(motorSpeedChange.Speed);

            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.OutputSetType,
                (byte)DaisyChainLayer.EV3,
                (byte)motorSpeedChange.OutputPort,
                (byte)MotorType.Large,

                (byte)OpCode.OutputSpeed,
                (byte)DaisyChainLayer.EV3,
                (byte)motorSpeedChange.OutputPort,
                (byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                speedBytes[0],
                speedBytes[1],

                (byte)OpCode.OutputStart,
                (byte)DaisyChainLayer.EV3,
                (byte)motorSpeedChange.OutputPort
            };
        }
    }
}
