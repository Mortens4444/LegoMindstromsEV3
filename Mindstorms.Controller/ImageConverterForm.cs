using Mindstorms.Core.Commands.LCD;
using Mindstorms.Core.ImageConverter;
using Utils.ImageConvertion.Converter;

namespace Mindstorms.Controller;

public partial class ImageConverterForm : Form
{
    private Bitmap? bitmap;
    private Bitmap? convertedBitmap;

    public ImageConverterForm()
    {
        InitializeComponent();
    }

    private void BtnBrowse_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog(this) == DialogResult.OK)
        {
            tbFilePathToConvert.Text = openFileDialog.FileName;
            if (File.Exists(tbFilePathToConvert.Text))
            {
                var image = Image.FromFile(tbFilePathToConvert.Text);
                bitmap = ((image.Width > LCDCommand.ScreenWidth) || (image.Height > LCDCommand.ScreenHeight)) ?
                    ResizeImage(image) : new Bitmap(image);
            }
            Convert();
        }
    }

    private static Bitmap ResizeImage(Image image)
    {
        var widthRation = (double)image.Width / LCDCommand.ScreenWidth;
        var heightRation = (double)image.Height / LCDCommand.ScreenHeight;
        var ration = Math.Max(widthRation, heightRation);
        var newWidth = (byte)(image.Width / ration);
        var newHeight = (byte)(image.Height / ration);
        return new Bitmap(image, new Size(newWidth, newHeight));
    }

    private void Convert()
    {
        if (bitmap != null)
        {
            var blackAndWhiteImageConverter = new BlackAndWhiteImageConverter((Bitmap)bitmap.Clone());
            blackAndWhiteImageConverter.Convert((byte)tbContrast.Value);
            convertedBitmap = blackAndWhiteImageConverter.WriteRgbBytesIntoBitmap();
            pbImage.Image = convertedBitmap;
            btnSaveRgf.Enabled = true;
        }
    }

    private void TbContrast_ValueChanged(object sender, EventArgs e)
    {
        Convert();
    }

    private void BtnSaveRgf_Click(object sender, EventArgs e)
    {
        if (convertedBitmap != null)
        {
            var bmpToRgfConverter = new BmpToRgfConverter();
            var ext = Path.GetExtension(tbFilePathToConvert.Text);
            bmpToRgfConverter.WriteToRgf(convertedBitmap, $"{tbFilePathToConvert.Text.Replace(ext, Core.Constants.GraphicsFileExtension)}");
        }
    }
}
