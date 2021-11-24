using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.LCD
{
    public class GetButtonStates : Command
    {
        public GetButtonStates()
        {
            data = new byte[]
            {
                (byte)CommandType.DirectCommand | (byte)Response.Required,
                7,
                0,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Pressed,
                (byte)Button.Back,
                1 | (byte)ParameterType.Variable | (byte)VariableScope.Global,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Pressed,
                (byte)Button.Up,
                2 | (byte)ParameterType.Variable | (byte)VariableScope.Global,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Pressed,
                (byte)Button.Center,
                3 | (byte)ParameterType.Variable | (byte)VariableScope.Global,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Pressed,
                (byte)Button.Down,
                4 | (byte)ParameterType.Variable | (byte)VariableScope.Global,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Pressed,
                (byte)Button.Left,
                5 | (byte)ParameterType.Variable | (byte)VariableScope.Global,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Pressed,
                (byte)Button.Right,
                6 | (byte)ParameterType.Variable | (byte)VariableScope.Global
            };
        }
    }
}
