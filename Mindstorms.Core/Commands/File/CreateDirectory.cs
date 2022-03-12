using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.File
{
    public class CreateDirectory : Command
    {
        public CreateDirectory(string fullPathDirectoryName)
        {
            data = SystemCommandWithReply;
            data.Add((byte)SystemCommand.CreateDir);
            data.Append(fullPathDirectoryName);
        }
    }
}
