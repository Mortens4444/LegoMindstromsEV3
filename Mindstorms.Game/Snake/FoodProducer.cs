using Mindstorms.Core.Commands.LCD;
using Mindstorms.Core.Drawing;
using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;

namespace Mindstorms.Game.Snake;

public class FoodProducer
{
    private EV3Circle? food;
    private static readonly Random random = new(Environment.TickCount);

    public FoodProducer()
    {
        ProduceFood();
    }

    public void DrawFood(Brick brick)
    {
        if (food != null)
        {
            brick.DrawCircle(food, LCDColor.Black);
        }
    }

    public EV3Circle? GetFoodLocation()
    {
        return food;
    }

    public void ProduceFood()
    {
        var x = (byte)random.Next(Constants.FoodRadius, LCDCommand.ScreenWidth - Constants.FoodRadius);
        var y = (byte)random.Next(Constants.FoodRadius, LCDCommand.ScreenHeight - Constants.FoodRadius);
        food = new EV3Circle(x, y, Constants.FoodRadius, true);
    }

    public static int GetFoodNutrition()
    {
        return random.Next(Constants.MaxNutrition);
    }
}
