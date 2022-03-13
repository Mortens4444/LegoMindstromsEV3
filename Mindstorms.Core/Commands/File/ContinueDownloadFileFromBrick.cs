using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.File
{
    public class ContinueDownloadFileFromBrick : Command
    {
        public ContinueDownloadFileFromBrick(byte fileHandle)
        {
            data = SystemCommandWithReply;
            data.Add(SystemCommand.ContinueFileUpload);
            data.Add(fileHandle);
            data.Append(Constants.ChunkSize);
        }
    }
}
