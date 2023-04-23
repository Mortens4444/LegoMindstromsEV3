namespace Utils.ImageConvertion.Converter;

public class BlackAndWhiteImageConverter
{
    private byte[] rgbBytes;
    private readonly byte byteCount;
    private readonly Bitmap bitmap;

    public BlackAndWhiteImageConverter(Bitmap bitmap)
    {
        this.bitmap = bitmap;
        var bitCount = PixelFormatConverter.ConvertToBitCount(bitmap.PixelFormat);
        byteCount = (byte)Math.Round((double)bitCount / 8);
        var bitmapToByteArrayConverter = new BitmapToByteArrayConverter();
        rgbBytes = bitmapToByteArrayConverter.Convert(bitmap).Item1;
    }

    public void Convert(byte contrast = 128)
    {
        var result = new byte[rgbBytes.Length];
        for (var i = 0; i < rgbBytes.Length; i += byteCount)
        {
            result[i] = ConvertPixel(i, contrast);
            result[i + (int)ColorComponent.Green] = result[i];
            result[i + (int)ColorComponent.Red] = result[i];
            result[i + (int)ColorComponent.Alpha] = 255;
        }
        rgbBytes = result;
    }

    public Bitmap WriteRgbBytesIntoBitmap()
    {
        var byteArrayToBitmapConverter = new ByteArrayToBitmapConverter();
        byteArrayToBitmapConverter.WriteBytesIntoBitmap(rgbBytes, bitmap);
        return bitmap;
    }

    private byte ConvertPixel(int index, byte contrast)
    {
        var color = Color.FromArgb(255, this[index + (int)ColorComponent.Red], this[index + (int)ColorComponent.Green], this[index]);
        var distance = (int)Math.Round((double)(color.R + color.G + color.B) / 3);
        return (distance < contrast) ? Byte.MinValue : Byte.MaxValue;
    }

    private byte this[int index]
    {
        get
        {
            return rgbBytes[index];
        }
        set
        {
            rgbBytes[index] = value;
        }
    }
}
