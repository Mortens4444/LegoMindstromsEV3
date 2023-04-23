using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic;

public class ATan : OneOperatorOperand
{
    public ATan(float value)
        : base(value, MathSubCode.ATan)
    {
    }
}
