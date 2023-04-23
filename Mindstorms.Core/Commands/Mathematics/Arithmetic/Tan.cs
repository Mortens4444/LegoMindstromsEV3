using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic;

public class Tan : OneOperatorOperand
{
    public Tan(float value)
        : base(value, MathSubCode.Tan)
    {
    }
}
