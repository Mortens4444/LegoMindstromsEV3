using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.LCD
{
    public class GraphDraw : LCDCommand
    {
#warning This command must be tested.
        public GraphDraw(byte view)
        {
            data = DirectCommandNoReply;
            data.Add((byte)OpCode.DrawUI);
            data.Add((byte)DrawSubCode.GraphDraw);
            data.AppendOneBytesParameter(view);
        }
    }
}
