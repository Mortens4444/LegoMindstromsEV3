using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.File
{
    public class UploadFileToBrick : Command
    {
        public UploadFileToBrick(string destinationFilePath, int fileSize)
        {
            data = SystemCommandWithReply;
            data.Add((byte)SystemCommand.BeginFileDownload);
            data.Append(fileSize);
            data.Append(destinationFilePath);
        }
    }
}
