using Mindstorms.Core.Commands.LCD;
using Mindstorms.Core.Drawing;
using Mindstorms.Game.General;

namespace Mindstorms.Game.Circles;

public class CircleEater : EV3Circle, IMoveable
{
    private static readonly Random random = new(Environment.TickCount);

    private int currentCycles;
    private sbyte moveModifierRigth = 0, moveModifierLeft = 0, moveModifierUp = 0, moveModifierDown = 0;
    private readonly sbyte PixelsToMove = 2;

    public CircleEater(byte x, byte y, byte radius) : base(x, y, radius, true)
    {
    }

    public CircleEater(byte radius) : base(
        (byte)random.Next(radius, LCDCommand.ScreenWidth - radius),
        (byte)random.Next(radius, LCDCommand.ScreenHeight - radius), radius, false)
    {
        ChangeMoving();
    }

    public void ChangeMoving()
    {
        if (currentCycles > 0)
        {
            currentCycles--;
        }
        else
        {
            currentCycles = random.Next(20, 100);
            ChangeDirection();
        }
    }

    private void ChangeDirection()
    {
        bool upAndDown, leftAndRight;

        do
        {
            upAndDown = GetRandomBool();
            leftAndRight = GetRandomBool();
        }
        while (!upAndDown && !leftAndRight);

        if (upAndDown)
        {
            if (GetRandomBool())
            {
                MoveDown(false);
                MoveUp(true);
            }
            else
            {
                MoveUp(false);
                MoveDown(true);
            }
        }
        else
        {
            MoveUp(false);
            MoveDown(false);
        }

        if (leftAndRight)
        {
            if (GetRandomBool())
            {
                MoveRight(false);
                MoveLeft(true);
            }
            else
            {
                MoveLeft(false);
                MoveRight(true);
            }
        }
        else
        {
            MoveLeft(false);
            MoveRight(false);
        }
    }

    public void MoveUp(bool move)
    {
        moveModifierUp = move ? (sbyte)-PixelsToMove : (sbyte)0;
    }

    public void MoveDown(bool move)
    {
        moveModifierDown = move ? PixelsToMove : (sbyte)0;
    }

    public void MoveRight(bool move)
    {
        moveModifierRigth = move ? PixelsToMove : (sbyte)0;
    }

    public void MoveLeft(bool move)
    {
        moveModifierLeft = move ? (sbyte)-PixelsToMove : (sbyte)0;
    }

    private static bool GetRandomBool()
    {
        return Convert.ToBoolean(random.Next(0, 2));
    }

    public void Move()
    {
        Center.X = (byte)(Center.X + moveModifierRigth + moveModifierLeft);
        if (Center.X - Radius < 0)
        {
            Center.X = (byte)(LCDCommand.ScreenWidth - Radius);
        }
        if (Center.X + Radius > LCDCommand.ScreenWidth)
        {
            Center.X = Radius;
        }
        Center.Y = (byte)(Center.Y + moveModifierUp + moveModifierDown);
        if (Center.Y - Radius < 0)
        {
            Center.Y = (byte)(LCDCommand.ScreenHeight - Radius);
        }
        if (Center.Y + Radius > LCDCommand.ScreenHeight)
        {
            Center.Y = Radius;
        }
    }
}
