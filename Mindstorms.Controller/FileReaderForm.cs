namespace Mindstorms.Controller;

public partial class FileReaderForm : Form
{
    public FileReaderForm(string fileName, string fileContent)
    {
        InitializeComponent();
        gbMain.Text = fileName;
        rtbFileContent.Text = fileContent;
    }

    private void FileReaderForm_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            Close();
        }
    }
}
