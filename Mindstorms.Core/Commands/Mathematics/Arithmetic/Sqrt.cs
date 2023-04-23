using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic;

public class Sqrt : OneOperatorOperand
{
    public Sqrt(float value)
        : base(value, MathSubCode.Sqrt)
    {
    }
}
