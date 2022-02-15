using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class GraphDraw : LCDCommand
    {
#warning 'This command must be tested.'
        public GraphDraw(byte view)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                0,
                0,

                (byte)OpCode.DrawUI,
                (byte)DrawSubCode.GraphDraw,
                
                (byte)ParameterFormat.Long | (byte)FollowType.OneByte,
                view
            };
        }
    }
}
