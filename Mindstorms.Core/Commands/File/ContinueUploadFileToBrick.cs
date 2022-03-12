using Mindstorms.Core.Enums;
using System.Collections.Generic;

namespace Mindstorms.Core.Commands.File
{
    public class ContinueUploadFileToBrick : Command
    {
        public ContinueUploadFileToBrick(byte fileHandle, IEnumerable<byte> fileContent)
        {
            data = SystemCommandNoReply;
            data.Add((byte)SystemCommand.ContinueFileDownload);
            data.Add(fileHandle);
            data.AddRange(fileContent);
        }
    }
}
