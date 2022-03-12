using Mindstorms.Core.Enums;
using System;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.Motor
{
    public class SetMediumMotorSpeed : Command
    {
        public SetMediumMotorSpeed(SetMotorSpeedParams motorSpeedChange, DaisyChainLayer daisyChainLayer)
        {
            var speedBytes = BitConverter.GetBytes(motorSpeedChange.Speed);

            data = DirectCommandNoReply;
            data.AddRange(new byte[]
            {
                (byte)OpCode.OutputSetType,
                (byte)daisyChainLayer,
                (byte)motorSpeedChange.OutputPort,
                (byte)MotorType.Medium,

                (byte)OpCode.OutputSpeed,
                (byte)daisyChainLayer,
                (byte)motorSpeedChange.OutputPort,
                (byte)ParameterFormat.Long | (byte)FollowType.TwoBytes,
                speedBytes[0],
                speedBytes[1],

                (byte)OpCode.OutputStart,
                (byte)daisyChainLayer,
                (byte)motorSpeedChange.OutputPort
            });
        }
    }
}
