using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.File
{
    public class GetFile : Command
    {
#warning This command must be tested.
        public GetFile(string filePath)
        {
            data = SystemCommandWithReply;
            data.Add((byte)SystemCommand.BeginGetFile);
            data.Append(Constants.ChunkSize);
            data.Append(filePath);
        }
    }
}
