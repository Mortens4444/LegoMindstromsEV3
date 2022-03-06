using System.Drawing;
using System.Drawing.Imaging;

namespace Utils.ImageConvertion.Converter
{
    public abstract class ByteArrayConverter
    {
        protected static BitmapData GetBitmapData(Bitmap bitmap)
        {
            var lockBitsRectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            return bitmap.LockBits(lockBitsRectangle, ImageLockMode.ReadOnly, bitmap.PixelFormat);
        }
    }
}
