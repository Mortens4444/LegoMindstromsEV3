using Mindstorms.Core.Commands.LCD;

namespace Mindstorms.Game.General;

public class MovingDifference
{
    public short DeltaX { get; }

    public short DeltaY { get; }

    public MovingDifference(short deltaX, short deltaY)
    {
        if (deltaX >= LCDCommand.ScreenWidth || deltaX <= -LCDCommand.ScreenWidth)
        {
            throw new ArgumentOutOfRangeException(nameof(deltaX), deltaX, $"The value must be between {-LCDCommand.ScreenWidth + 1} and {LCDCommand.ScreenWidth - 1}.");
        }
        if (deltaY >= LCDCommand.ScreenHeight || deltaY <= -LCDCommand.ScreenHeight)
        {
            throw new ArgumentOutOfRangeException(nameof(deltaY), deltaY, $"The value must be between {-LCDCommand.ScreenHeight + 1} and {LCDCommand.ScreenHeight - 1}.");
        }

        DeltaX = deltaX;
        DeltaY = deltaY;
    }
}
