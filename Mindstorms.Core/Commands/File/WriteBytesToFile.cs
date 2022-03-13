using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.File
{
#warning This command must be tested.
    public class WriteBytesToFile : Command
    {
        public WriteBytesToFile(byte handle, byte[] bytes)
        {
            data = DirectCommandNoReply;
            data.AddRange(new byte[]
            {
                OpCode.File,
                FileSubCode.WriteBytes,
                handle,
                (byte)bytes.Length
            });
            //data.AppendTwoBytesParameter(Constants.ChunkSize);
            data.AddRange(bytes);
            data.Add(0);
        }
    }
}
