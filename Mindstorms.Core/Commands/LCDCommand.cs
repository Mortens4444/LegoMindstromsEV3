using System;

namespace Mindstorms.Core
{
    public abstract class LCDCommand : Command
    {
        private const byte ScreenWidth = 178;
        private const byte ScreenHeight = 128;

        public void ValidatePixel(byte x, byte y)
        {
            if (!IsValidPixel(x, y))
            {
                throw new Exception($"The pixel should be in the screen bounds ({ScreenWidth}x{ScreenHeight})");
            }
        }

        private bool IsValidPixel(byte x, byte y)
        {
            return x < ScreenWidth && y < ScreenHeight;
        }
    }
}