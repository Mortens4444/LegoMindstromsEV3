using Mindstorms.Core.Enums;
using Mindstorms.Core.Extensions;

namespace Mindstorms.Core.Commands.Mathematics;

public abstract class OneOperatorOperand : Command
{
    public OneOperatorOperand(float value, MathSubCode mathSubCode)
    {
        data = GetDirectCommandWithReply(4);
        data.Add(OpCode.Math);
        data.Add(mathSubCode);
        data.AppendFourBytesParameter(value);
        data.Add(ParameterType.Variable | VariableScope.Global);
    }
}
