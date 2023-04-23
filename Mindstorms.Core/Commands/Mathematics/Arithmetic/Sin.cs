using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic;

public class Sin : OneOperatorOperand
{
    public Sin(float value)
        : base(value, MathSubCode.Sin)
    {
    }
}
