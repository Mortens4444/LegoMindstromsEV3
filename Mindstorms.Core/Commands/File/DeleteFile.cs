using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.File
{
    public class DeleteFile : Command
    {
        public DeleteFile(string fullPathFileName)
        {
            data = SystemCommandWithReply;
            data.Add(SystemCommand.DeleteFile);
            data.Append(fullPathFileName);
        }
    }
}
