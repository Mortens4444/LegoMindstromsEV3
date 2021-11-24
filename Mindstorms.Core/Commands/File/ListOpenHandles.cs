using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.File
{
    public class ListOpenHandles : Command
    {
#warning This command must be tested.
        public ListOpenHandles()
        {
            data = new byte[]
            {
                (byte)CommandType.SystemCommand | (byte)Response.Required,
                (byte)SystemCommand.ListOpenHandles
            };
        }
    }
}
