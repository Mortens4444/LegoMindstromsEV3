using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Firmware
{
    public class EnterFirmwareUpdate : Command
    {
#warning This command must be tested.
        public EnterFirmwareUpdate()
        {
            data = SystemCommandNoReply;
            data.Add(SystemCommand.EnterFirmwareUpdate);
        }
    }
}
