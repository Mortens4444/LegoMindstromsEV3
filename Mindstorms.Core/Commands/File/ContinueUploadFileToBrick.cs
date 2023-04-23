using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.File;

public class ContinueUploadFileToBrick : Command
{
    public ContinueUploadFileToBrick(byte fileHandle, IEnumerable<byte> fileContent)
    {
        data = SystemCommandNoReply;
        data.Add(SystemCommand.ContinueFileDownload);
        data.Add(fileHandle);
        data.AddRange(fileContent);
    }
}
