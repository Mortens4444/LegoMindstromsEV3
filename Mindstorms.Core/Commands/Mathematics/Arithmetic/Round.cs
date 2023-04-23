using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic;

public class Round : OneOperatorOperand
{
    public Round(float value)
        : base(value, MathSubCode.Round)
    {
    }
}
