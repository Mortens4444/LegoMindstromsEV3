namespace Utils.ImageConvertion.Converter;

internal class ByteArrayToBitmapConverter : ByteArrayConverter
{
    public unsafe void WriteBytesIntoBitmap(byte[] bitmapRgbBytes, Bitmap bitmap)
    {
        var bmpData = GetBitmapData(bitmap);
        var bytes = (byte*)bmpData.Scan0;
        for (var i = 0; i < bitmapRgbBytes.Length; i++)
        {
            bytes[i] = bitmapRgbBytes[i];
        }
        bitmap.UnlockBits(bmpData);
        GC.Collect();
    }
}
