namespace Mindstorms.Core.FileWriter;

public interface IWriter
{
    void Write(byte[] buffer, int offset, int count);
}