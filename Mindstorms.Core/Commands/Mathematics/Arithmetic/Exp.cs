using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic;

public class Exp : OneOperatorOperand
{
    public Exp(float value)
        : base(value, MathSubCode.Exp)
    {
    }
}
