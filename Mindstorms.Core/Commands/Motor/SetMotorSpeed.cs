using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;
//using System;

namespace Mindstorms.Core.Commands.Motor
{
    public class SetMotorSpeed : Command
    {
        public SetMotorSpeed(SetMotorSpeedParams motorSpeedChange, DaisyChainLayer daisyChainLayer, MotorType motorType)
        {
            data = DirectCommandNoReply;
            data.AddRange(new byte[]
            {
                OpCode.OutputSetType,
                daisyChainLayer,
                motorSpeedChange.OutputPort,
                motorType,

                OpCode.OutputSpeed,
                daisyChainLayer,
                motorSpeedChange.OutputPort
            });
            data.AppendTwoBytesParameter((ushort)motorSpeedChange.Speed);
            data.AddRange(new byte[]
            {
                OpCode.OutputStart,
                daisyChainLayer,
                motorSpeedChange.OutputPort
            });
        }
    }
}
