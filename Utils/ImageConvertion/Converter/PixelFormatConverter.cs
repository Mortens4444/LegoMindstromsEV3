using System.Drawing.Imaging;
using System.Globalization;

namespace Utils.ImageConvertion.Converter;

public class PixelFormatConverter
{
    public static byte ConvertToBitCount(PixelFormat format)
    {
        if (format == PixelFormat.Canonical)
        {
            return 32;
        }

        var formatName = format.ToString();
        if (formatName[..6] != "Format")
        {
            throw new Exception($"Unknown pixel format: {format}");
        }

        formatName = formatName.Substring(6, 2);
        return Convert.ToByte(Char.IsNumber(formatName[1]) ? formatName : formatName[0].ToString(CultureInfo.InvariantCulture));
    }
}
