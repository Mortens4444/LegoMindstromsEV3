﻿using Mindstorms.Core.Drawing;

namespace Mindstorms.Core.Commands.LCD;

public abstract class LCDCommand : Command
{
    public const byte ScreenWidth = 178;
    public const byte ScreenHeight = 128;

    public const byte HorizontalCenter = ScreenWidth / 2;
    public const byte VerticalCenter = ScreenHeight / 2;

    public void ValidatePixel(byte x, byte y)
    {
        if (!IsValidPixel(x, y))
        {
            throw new Exception($"The pixel should be in the screen bounds ({ScreenWidth}x{ScreenHeight})");
        }
    }

    private static bool IsValidPixel(byte x, byte y)
    {
        return x < ScreenWidth && y < ScreenHeight;
    }

    public static bool IsPointInScreen(EV3Point point)
    {
        return point.X >= 0 && point.X < ScreenWidth && point.Y >= 0 && point.Y < ScreenHeight;
    }
}