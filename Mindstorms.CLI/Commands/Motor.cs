using Mindstorms.Core;
using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindstorms.CLI.Commands
{
    internal class Motor : ICliCommand
    {
        public string Name => nameof(Motor);

        public void Action(ref Brick brick, IEnumerable<string> arguments)
        {
            var subCommand = arguments.ElementAt(0).ToLower();
            var ouputPort = OutputPort.Parse(arguments.ElementAt(1));

            DaisyChainLayer daisyChainLayer = arguments.Count() > 3 ? DaisyChainLayer.Parse(arguments.ElementAt(3)) : DaisyChainLayer.EV3;
            SetMotorSpeedParams setMotorSpeedParams;

            switch (subCommand)
            {
                case "start":
                    var speed = Convert.ToSByte(arguments.ElementAt(2));
                    setMotorSpeedParams = new SetMotorSpeedParams(ouputPort, speed);
                    brick.SetLargeMotorSpeed(daisyChainLayer, setMotorSpeedParams);
                    break;

                case "stop":
                    var breakType = BreakType.Parse(arguments.ElementAt(2));
                    brick.StopMotor(daisyChainLayer, ouputPort, breakType);
                    break;
            }
        }
    }
}
