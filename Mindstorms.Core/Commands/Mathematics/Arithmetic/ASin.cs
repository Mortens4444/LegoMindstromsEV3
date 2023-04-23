using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic;

public class ASin : OneOperatorOperand
{
    public ASin(float value)
        : base(value, MathSubCode.ASin)
    {
    }
}
