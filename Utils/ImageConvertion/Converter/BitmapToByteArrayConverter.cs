using System.Drawing.Imaging;

namespace Utils.ImageConvertion.Converter;

public class BitmapToByteArrayConverter : ByteArrayConverter
{
    public unsafe (byte[], int) Convert(Bitmap bitmap)
    {
        var bmpData = GetBitmapData(bitmap);
        var bitmapRgbBytes = new byte[GetRgbByteArrayLength(bmpData)];
        var bytes = (byte*)bmpData.Scan0;
        for (var i = 0; i < bitmapRgbBytes.Length; i++)
        {
            bitmapRgbBytes[i] = bytes[i];
        }

        bitmap.UnlockBits(bmpData);
        GC.Collect();
        return (bitmapRgbBytes, bmpData.Stride);
    }

    private static int GetRgbByteArrayLength(BitmapData bitmapData)
    {
        return bitmapData.Stride * bitmapData.Height;
    }
}
