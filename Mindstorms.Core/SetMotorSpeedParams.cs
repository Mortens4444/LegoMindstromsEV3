using Mindstorms.Core.Enums;

namespace Mindstorms.Core;

public class SetMotorSpeedParams
{
    private const sbyte MaxSpeed = 100;
    private const sbyte MinSpeed = -100;

    public OutputPort OutputPort;
    public sbyte Speed;

    public SetMotorSpeedParams(OutputPort outputPort, sbyte speed)
    {
        OutputPort = outputPort;
        Speed = Math.Max(Math.Min(speed, MaxSpeed), MinSpeed);
    }
}
