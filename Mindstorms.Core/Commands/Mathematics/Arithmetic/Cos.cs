using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic;

public class Cos : OneOperatorOperand
{
    public Cos(float value)
        : base(value, MathSubCode.Cos)
    {
    }
}
