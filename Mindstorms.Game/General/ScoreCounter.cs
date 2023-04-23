namespace Mindstorms.Game.General;

public class ScoreCounter
{
    public int Score { get; private set; }

    public void Add(int amount)
    {
        Score += amount;
    }
}
