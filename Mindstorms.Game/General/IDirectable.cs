namespace Mindstorms.Game.General;

public interface IDirectable
{
    Direction Direction { get; }

    void ChangeDirection(Direction newDirection);
}