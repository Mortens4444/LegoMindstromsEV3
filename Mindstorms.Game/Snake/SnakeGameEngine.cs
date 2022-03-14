using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using Mindstorms.Core.Responses;
using Mindstorms.Game.General;

namespace Mindstorms.Game.Snake
{
    public class SnakeGameEngine : GameEngineBase
    {
        private Wormy worm;
        private DirectionHandler directionHandler;
        private FoodProducer foodProducer;
        private ScoreCounter scoreCounter;

        public SnakeGameEngine(Brick brick) : base(brick)
        { }

        protected override void StartNewGame()
        {
            worm = new Wormy();
            directionHandler = new DirectionHandler(worm);
            foodProducer = new FoodProducer();
            scoreCounter = new ScoreCounter();
            inGame = true;
            message = GameOver;
        }

        protected override ButtonStates GameMoment()
        {
            inGame &= worm.MoveForward();
            if (inGame)
            {
                worm.Draw(brick);

                foodProducer.DrawFood(brick);
                if (worm.CanConsumeFood(foodProducer.GetFoodLocation()))
                {
                    var nutrition = foodProducer.GetFoodNutrition();
                    scoreCounter.Add(nutrition * 2);
                    if (scoreCounter.Score > Constants.MaxPoints)
                    {
                        message = "You won!";
                        inGame = false;
                    }
                    foodProducer.ProduceFood();
                    worm.Grow(nutrition);
                }
                brick.DrawString(0, 0, $"Score: {Constants.MaxPoints} / {scoreCounter.Score}", LCDColor.Black, FontType.Tiny);
            }

            return directionHandler.HandleKeyPress(brick);
        }
    }
}
