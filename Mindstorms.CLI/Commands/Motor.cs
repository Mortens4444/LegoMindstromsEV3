using Mindstorms.Core;
using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;

namespace Mindstorms.CLI.Commands;

internal class Motor : ICliCommand
{
    public string Name => nameof(Motor);

    public List<string> Aliases => new() { "engine" };

    public void Action(ref Brick? brick, IList<string> arguments)
    {
        if (brick == null)
        {
            Console.Error.WriteLine("Use 'connect' before this command.");
        }
        else
        {
            var subCommand = arguments[0].ToLower();
            var ouputPort = OutputPort.Parse(arguments[1]) ?? OutputPort.BC;
            var daisyChainLayer = DaisyChainLayer.Parse(arguments[3]) ?? DaisyChainLayer.EV3;

            switch (subCommand)
            {
                case "start":
                    var speed = Convert.ToSByte(arguments[2]);
                    var setMotorSpeedParams = new SetMotorSpeedParams(ouputPort, speed);
                    brick.SetLargeMotorSpeed(daisyChainLayer, setMotorSpeedParams);
                    break;

                case "stop":
                    var breakType = BreakType.Parse(arguments[2]) ?? BreakType.Break;
                    brick.StopMotor(daisyChainLayer, ouputPort, breakType);
                    break;
            }
        }
    }
}
