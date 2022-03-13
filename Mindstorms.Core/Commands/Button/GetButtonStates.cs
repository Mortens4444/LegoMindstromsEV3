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
                OpCode.Button,
                ButtonEvent.Pressed,
                ButtonType.Up,
                0 | ParameterType.Variable | VariableScope.Global,

                OpCode.Button,
                ButtonEvent.Pressed,
                ButtonType.Center,
                1 | ParameterType.Variable | VariableScope.Global,

                OpCode.Button,
                ButtonEvent.Pressed,
                ButtonType.Down,
                2 | ParameterType.Variable | VariableScope.Global,

                OpCode.Button,
                ButtonEvent.Pressed,
                ButtonType.Right,
                3 | ParameterType.Variable | VariableScope.Global,

                OpCode.Button,
                ButtonEvent.Pressed,
                ButtonType.Left,
                4 | ParameterType.Variable | VariableScope.Global,

                OpCode.Button,
                ButtonEvent.Pressed,
                ButtonType.Back,
                5 | ParameterType.Variable | VariableScope.Global,

                OpCode.Button,
                ButtonEvent.Pressed,
                ButtonType.Any,
                6 | ParameterType.Variable | VariableScope.Global
            });
        }
    }
}
