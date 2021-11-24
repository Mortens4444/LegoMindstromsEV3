using Mindstorms.Core.Enums;
using System;

namespace Mindstorms.Core
{
    public class SetMotorSpeedParams
    {
        private const short MaxSpeed = 100;
        private const short MinSpeed = -100;

        public OutputPort OutputPort;
        public short Speed;

        public SetMotorSpeedParams(OutputPort outputPort, short speed)
        {
            OutputPort = outputPort;
            Speed = Math.Max(Math.Min(speed, MaxSpeed), MinSpeed);
        }
    }
}
