using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic
{
    public class Negate : OneOperatorOperand
    {
        public Negate(float value)
            : base(value, MathSubCode.Negate)
        {
        }
    }
}
