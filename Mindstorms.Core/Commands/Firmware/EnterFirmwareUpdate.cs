using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.File
{
    public class EnterFirmwareUpdate : Command
    {
#warning This command must be tested.
        public EnterFirmwareUpdate()
        {
            data = new byte[]
            {
                (byte)CommandType.SystemCommand | (byte)Response.NotExpected,
                (byte)SystemCommand.EnterFirmwareUpdate
            };
        }
    }
}
