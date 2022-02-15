namespace Mindstorms.Game.General
{
    public abstract class Directable : IDirectable
    {
        public Direction Direction { get; set; } = Direction.East;

        public void ChangeDirection(Direction newDirection)
        {
            int sum = (int)Direction + (int)newDirection;
            if (sum != 0)
            {
                Direction = newDirection;
            }
        }
    }
}
