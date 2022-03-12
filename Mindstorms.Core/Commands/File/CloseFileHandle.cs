using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.File
{
    public class CloseFileHandle : Command
    {
#warning This command must be tested.
        public CloseFileHandle(byte fileHandle, string hash)
        {
            data = SystemCommandWithReply;
            data.Add((byte)SystemCommand.CloseFileHandle);
            data.Add(fileHandle);
            data.Append(hash);
        }
    }
}
