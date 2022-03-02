using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using Mindstorms.Core.Resources;

namespace Mindstorms.Game.General
{
    public static class GameFrame
    {
        /// <summary>
        /// Dirty hack to get an application running in the background.
        /// </summary>
        /// <param name="brick">The EV3 brick</param>
        public static void UploadAndStart(Brick brick)
        {
            var destinationAppName = ResourceUploader.UploadApplication(brick, "GameFrame.rbf");
            brick.Start(destinationAppName);
            brick.ChangeLedsState(LedPattern.Off);
        }
    }
}
