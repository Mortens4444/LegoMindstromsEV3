namespace Mindstorms.Game.General;

public class MovingDifferenceProvider
{
    public const byte PixelsToMove = 4;

    private readonly Dictionary<Direction, MovingDifference> differences = new()
    {
        { Direction.East, new MovingDifference(PixelsToMove, 0) },
        { Direction.West, new MovingDifference(-PixelsToMove, 0) },
        { Direction.South, new MovingDifference(0, PixelsToMove) },
        { Direction.North, new MovingDifference(0, -PixelsToMove) }
    };

    public MovingDifference GetMovingDifference(Direction direction)
    {
        return differences[direction];
    }
}
