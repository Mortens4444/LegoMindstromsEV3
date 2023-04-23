using System.Text;

namespace Mindstorms.Core.FileWriter;

public class StringWriter : IWriter
{
    private readonly StringBuilder stringBuilder;

    public StringWriter(int fileSize)
    {
        stringBuilder = new StringBuilder(fileSize);
    }

    public void Write(byte[] buffer, int offset, int count)
    {
        var textPart = Constants.DefaultEncoding.GetString(buffer, offset, count);
        stringBuilder.Append(textPart);
    }

    public string GetContent()
    {
        return stringBuilder.ToString().Replace("\0", ".");
    }
}
