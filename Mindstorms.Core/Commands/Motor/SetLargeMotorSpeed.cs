using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core.Commands.Motor
{
    public class SetLargeMotorSpeed : Command
    {
        public SetLargeMotorSpeed(SetMotorSpeedParams motorSpeedChange, DaisyChainLayer daisyChainLayer)
        {
            var speedBytes = BitConverter.GetBytes(motorSpeedChange.Speed);

            data = DirectCommandNoReply;
            data.AddRange(new byte[]
            {
                OpCode.OutputSetType,
                daisyChainLayer,
                motorSpeedChange.OutputPort,
                MotorType.Large,

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
