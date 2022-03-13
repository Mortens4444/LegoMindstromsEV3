using Mindstorms.Core.Enums;
using System;

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
                OpCode.OutputSetType,
                daisyChainLayer,
                motorSpeedChange.OutputPort,
                MotorType.Medium,

                OpCode.OutputSpeed,
                daisyChainLayer,
                motorSpeedChange.OutputPort,
                ParameterFormat.Long | FollowType.TwoBytes,
                speedBytes[0],
                speedBytes[1],

                OpCode.OutputStart,
                daisyChainLayer,
                motorSpeedChange.OutputPort
            });
        }
    }
}
