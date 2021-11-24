using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class PressButton : Command
    {
        public PressButton(Button button, ButtonEvent buttonEvent)
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.NotExpected,
                1,
                0,

                (byte)OpCode.Button,
                (byte)buttonEvent,
                (byte)button,
                1 | (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
