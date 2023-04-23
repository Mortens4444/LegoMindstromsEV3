using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.Mathematics;

public abstract class TwoOperatorOperand : Command
{
    public TwoOperatorOperand(byte value1, byte value2, OpCode operand)
    {
        data = GetDirectCommandWithReply(1);
        data.Add(operand);
        data.AppendOneBytesParameter(value1);
        data.AppendOneBytesParameter(value2);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }

    public TwoOperatorOperand(short value1, short value2, OpCode operand)
    {
        data = GetDirectCommandWithReply(2);
        data.Add(operand);
        data.AppendTwoBytesParameter(value1);
        data.AppendTwoBytesParameter(value2);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }

    public TwoOperatorOperand(int value1, int value2, OpCode operand)
    {
        data = GetDirectCommandWithReply(4);
        data.Add(operand);
        data.AppendFourBytesParameter(value1);
        data.AppendFourBytesParameter(value2);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }

    public TwoOperatorOperand(float value1, float value2, OpCode operand)
    {
        data = GetDirectCommandWithReply(4);
        data.Add(operand);
        data.AppendFourBytesParameter(value1);
        data.AppendFourBytesParameter(value2);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }
}
