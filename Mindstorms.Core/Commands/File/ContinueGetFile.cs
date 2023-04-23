using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.File;

public class ContinueGetFile : Command
{
#warning This command must be tested.
    public ContinueGetFile(byte fileHandle)
    {
        data = SystemCommandWithReply;
        data.Add(SystemCommand.ContinueGetFile);
        data.Add(fileHandle);
        data.Append(Constants.ChunkSize);
    }
}
