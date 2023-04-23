using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.File;

public class DownloadFileFromBrick : Command
{
    public DownloadFileFromBrick(string filePath, int fileSize)
    {
        var bytesToRead = (ushort)Math.Min(fileSize, Constants.ChunkSize);

        data = SystemCommandWithReply;
        data.Add(SystemCommand.BeginFileUpload);
        data.Append(bytesToRead);
        data.Append(filePath);
    }
}
