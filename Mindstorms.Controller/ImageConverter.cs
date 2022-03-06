using Mindstorms.Core.Commands.LCD;
using Mindstorms.Core.ImageConverter;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Utils.ImageConvertion.Converter;

namespace Mindstorms.Controller
{
    public partial class ImageConverter : Form
    {
        private Bitmap bitmap;
        private Bitmap convertedBitmap;

        public ImageConverter()
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
                    bitmap = ResizeImage(image);
                }
                Convert();
            }
        }

        private Bitmap ResizeImage(Image image)
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
            var bmpToRgfConverter = new BmpToRgfConverter();
            var ext = Path.GetExtension(tbFilePathToConvert.Text);
            bmpToRgfConverter.WriteToRgf(convertedBitmap, $"{tbFilePathToConvert.Text.Replace(ext, Core.Constants.GraphicsFileExtension)}");
        }
    }
}
