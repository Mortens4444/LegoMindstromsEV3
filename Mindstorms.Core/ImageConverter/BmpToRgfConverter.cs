using Mindstorms.Core.Commands.LCD;
using System.Drawing;
using System.Drawing.Imaging;
using Utils.ImageConvertion.Converter;

namespace Mindstorms.Core.ImageConverter;

public class BmpToRgfConverter
{
    private const int BitsInByte = 8;
    private readonly BitmapToByteArrayConverter bitmapToByteArrayConverter = new();

    public void WriteToRgf(Bitmap bitmap, string filePath)
    {
        var colorComponents = GetColorComponents(bitmap.PixelFormat);
        var convertionResult = bitmapToByteArrayConverter.Convert(bitmap);
        var imageBytes = convertionResult.Item1;
        var stride = convertionResult.Item2;

        var rgfBytes = new List<byte>
        {
            LCDCommand.ScreenWidth - 2,//(byte)Math.Min(bitmap.Width, LCDCommand.ScreenWidth - 2),
            (byte)Math.Min(bitmap.Height, LCDCommand.ScreenHeight),
        };

        byte pixelIndex = 0;
        for (int row = 0; row < rgfBytes[1]; row++)
        {
            for (int column = 0; column < rgfBytes[0]; column++)
            {
                var ix = row * stride + (column * colorComponents);
                if (pixelIndex == 0)
                {
                    rgfBytes.Add(0);
                }
                if (ix >= imageBytes.Length)
                {
                    break;
                }
                rgfBytes[^1] |= GetValue(imageBytes[ix], pixelIndex++);
                if (pixelIndex == BitsInByte)
                {
                    pixelIndex = 0;
                }
            }
        }

        File.WriteAllBytes(filePath, rgfBytes.ToArray());
    }

    private static int GetColorComponents(PixelFormat pixelFormat)
    {
        return pixelFormat switch
        {
            PixelFormat.Format24bppRgb => 3,
            PixelFormat.Format32bppArgb or PixelFormat.Format32bppRgb => 4,
            PixelFormat.Format48bppRgb => 6,
            PixelFormat.Format64bppArgb or PixelFormat.Format64bppPArgb => 8,
            PixelFormat.Format16bppRgb565 or PixelFormat.Format16bppRgb555 or PixelFormat.Format16bppArgb1555 or PixelFormat.Format16bppGrayScale => 2,
            PixelFormat.Format8bppIndexed => 1,
            _ => throw new NotImplementedException(),
        };
    }

    private static byte GetValue(byte rgbByte, byte index)
    {
        if (rgbByte == Byte.MinValue)
        {
            return (byte)Math.Pow(2, index);
        }

        return 0;
    }
}
