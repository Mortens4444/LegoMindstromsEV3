using Mindstorms.Core.Commands.LCD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Utils.ImageConvertion.Converter;

namespace Mindstorms.Core.ImageConverter
{
    public class BmpToRgfConverter
    {
        private const int BitsInByte = 8;
        private readonly BitmapToByteArrayConverter bitmapToByteArrayConverter = new BitmapToByteArrayConverter();

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
                    rgfBytes[rgfBytes.Count - 1] |= GetValue(imageBytes[ix], pixelIndex++);
                    if (pixelIndex == BitsInByte)
                    {
                        pixelIndex = 0;
                    }
                }
            }

            File.WriteAllBytes(filePath, rgfBytes.ToArray());
        }

        private int GetColorComponents(PixelFormat pixelFormat)
        {
            switch (pixelFormat)
            {
                case PixelFormat.Format24bppRgb:
                    return 3;
                case PixelFormat.Format32bppArgb:
                case PixelFormat.Format32bppRgb:
                    return 4;
                case PixelFormat.Format48bppRgb:
                    return 6;
                case PixelFormat.Format64bppArgb:
                case PixelFormat.Format64bppPArgb:
                    return 8;
                case PixelFormat.Format16bppRgb565:
                case PixelFormat.Format16bppRgb555:
                case PixelFormat.Format16bppArgb1555:
                case PixelFormat.Format16bppGrayScale:
                    return 2;
                case PixelFormat.Format8bppIndexed:
                    return 1;
            }
            

            throw new NotImplementedException();
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
}
