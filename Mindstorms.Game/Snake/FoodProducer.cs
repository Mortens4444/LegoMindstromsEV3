using Mindstorms.Core.Commands.LCD;
using Mindstorms.Core.Drawing;
using Mindstorms.Core.EV3;
using System;

namespace Mindstorms.Game.Snake
{
    public class FoodProducer
    {
        private EV3Circle circle;
        private static readonly Random random = new Random(Environment.TickCount);

        public FoodProducer()
        {
            ProduceFood();
        }

        public void DrawFood(Brick brick)
        {
            brick.DrawCircle(circle);
        }

        public EV3Circle GetFoodLocation()
        {
            return circle;
        }

        public void ProduceFood()
        {
            var x = (byte)random.Next(Constants.FoodRadius, LCDCommand.ScreenWidth - Constants.FoodRadius);
            var y = (byte)random.Next(Constants.FoodRadius, LCDCommand.ScreenHeight - Constants.FoodRadius);
            circle = new EV3Circle(x, y, Constants.FoodRadius, true);
        }

        public int GetFoodNutrition()
        {
            return random.Next(Constants.MaxNutrition);
        }
    }
}
