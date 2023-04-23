using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;

namespace Mindstorms.CLI.Commands;

internal class LCD : ICliCommand
{
    public string Name => nameof(LCD);

    public List<string> Aliases => new() { "screen" };

    public void Action(ref Brick? brick, IList<string> arguments)
    {
        if (brick == null)
        {
            Console.Error.WriteLine("Use 'connect' before this command.");
        }
        else
        {
            var subCommand = arguments[0].ToLower();
            LCDColor color;
            byte x = 0, y = 0;
            bool fill;

            if (arguments.Count > 1)
            {
                x = Convert.ToByte(arguments[1]);
                y = Convert.ToByte(arguments[2]);
            }

            switch (subCommand)
            {
                case "clean":
                    brick.ClearScreen();
                    break;

                case "pixel":
                    color = LCDColor.Parse(arguments[3]) ?? LCDColor.Black;
                    brick.PutPixel(x, y, color);
                    break;

                case "line":
                    var x2 = Convert.ToByte(arguments[3]);
                    var y2 = Convert.ToByte(arguments[4]);
                    color = LCDColor.Parse(arguments[5]) ?? LCDColor.Black;
                    brick.DrawLine(x, y, x2, y2, color);
                    break;

                case "circle":
                    var r = Convert.ToByte(arguments[3]);
                    color = LCDColor.Parse(arguments[4]) ?? LCDColor.Black;
                    fill = Convert.ToBoolean(arguments[5]);
                    brick.DrawCircle(x, y, r, color, fill);
                    break;

                case "rectangle":
                    var width = Convert.ToByte(arguments[3]);
                    var height = Convert.ToByte(arguments[4]);
                    color = LCDColor.Parse(arguments[5]) ?? LCDColor.Black;
                    fill = Convert.ToBoolean(arguments[6]);
                    brick.DrawRectangle(x, y, width, height, color, fill);
                    break;

                case "string":
                    color = LCDColor.Parse(arguments[3]) ?? LCDColor.Black;
                    var fontType = FontType.Parse(arguments[4]) ?? FontType.Normal;
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
