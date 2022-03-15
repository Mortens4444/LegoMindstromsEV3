using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindstorms.CLI.Commands
{
    internal class LCD : ICliCommand
    {
        public string Name => nameof(LCD);

        public void Action(ref Brick brick, IEnumerable<string> arguments)
        {
            var subCommand = arguments.ElementAt(0).ToLower();
            LCDColor color;
            byte x = 0, y = 0;
            bool fill;
            
            if (arguments.Count() > 1)
            {
                x = Convert.ToByte(arguments.ElementAt(1));
                y = Convert.ToByte(arguments.ElementAt(2));
            }

            switch (subCommand)
            {
                case "clean":
                    brick.ClearScreen();
                    break;

                case "pixel":
                    color = LCDColor.Parse(arguments.ElementAt(3));
                    brick.PutPixel(x, y, color);
                    break;

                case "line":
                    var x2 = Convert.ToByte(arguments.ElementAt(3));
                    var y2 = Convert.ToByte(arguments.ElementAt(4));
                    color = LCDColor.Parse(arguments.ElementAt(5));
                    brick.DrawLine(x, y, x2, y2, color);
                    break;

                case "circle":
                    var r = Convert.ToByte(arguments.ElementAt(3));
                    color = LCDColor.Parse(arguments.ElementAt(4));
                    fill = Convert.ToBoolean(arguments.ElementAt(5));
                    brick.DrawCircle(x, y, r, color, fill);
                    break;

                case "rectangle":
                    var width = Convert.ToByte(arguments.ElementAt(3));
                    var height = Convert.ToByte(arguments.ElementAt(4));
                    color = LCDColor.Parse(arguments.ElementAt(5));
                    fill = Convert.ToBoolean(arguments.ElementAt(6));
                    brick.DrawRectangle(x, y, width, height, color, fill);
                    break;

                case "string":
                    color = LCDColor.Parse(arguments.ElementAt(3));
                    var fontType = FontType.Parse(arguments.ElementAt(4));
                    var text = String.Join(" ", arguments.Skip(5));
                    brick.DrawString(x, y, text, color, fontType);
                    break;

                case "update":
                    brick.UpdateScreen();
                    break;
            }
        }
    }
}
