using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using System;
using System.IO;
using System.Linq;

namespace Mindstorms.Game.General
{
    public static class GameFrame
    {
        /// <summary>
        /// Dirty hack to get an application running in the background.
        /// </summary>
        /// <param name="brick">The EV3 brick</param>
        public static void Upload(Brick brick)
        {
            var destinationFolder = "/home/root/lms2012/prjs";
            var applicationName = "GameFrame.rbf";

            var destinationAppName = $"{destinationFolder}/{applicationName}";

            var folderContent = brick.GetFolderContent(destinationFolder);
            if (!folderContent.Any(c => c.EndsWith($" {applicationName}")))
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", applicationName);
                brick.CopyFileToBrick(path, destinationAppName);
            }
            brick.Start(destinationAppName);
            brick.ChangeLedsState(LedPattern.Off);
        }
    }
}
