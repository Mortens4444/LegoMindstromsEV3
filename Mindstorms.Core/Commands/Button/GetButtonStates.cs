using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Button
{
    public class GetButtonStates : Command
    {
        public GetButtonStates()
        {
            data = GetDirectCommandWithReply(7);
            data.AddRange(new byte[]
            {
                (byte)OpCode.Button,
                (byte)ButtonEvent.Pressed,
                (byte)ButtonType.Up,
                0 | (byte)ParameterType.Variable | (byte)VariableScope.Global,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Pressed,
                (byte)ButtonType.Center,
                1 | (byte)ParameterType.Variable | (byte)VariableScope.Global,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Pressed,
                (byte)ButtonType.Down,
                2 | (byte)ParameterType.Variable | (byte)VariableScope.Global,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Pressed,
                (byte)ButtonType.Right,
                3 | (byte)ParameterType.Variable | (byte)VariableScope.Global,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Pressed,
                (byte)ButtonType.Left,
                4 | (byte)ParameterType.Variable | (byte)VariableScope.Global,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Pressed,
                (byte)ButtonType.Back,
                5 | (byte)ParameterType.Variable | (byte)VariableScope.Global,

                (byte)OpCode.Button,
                (byte)ButtonEvent.Pressed,
                (byte)ButtonType.Any,
                6 | (byte)ParameterType.Variable | (byte)VariableScope.Global
            });
        }
    }
}
