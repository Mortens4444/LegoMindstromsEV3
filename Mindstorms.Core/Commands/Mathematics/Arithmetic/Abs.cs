using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic
{
    public class Abs : OneOperatorOperand
    {
        public Abs(float value)
            : base(value, MathSubCode.Abs)
        {
        }
    }
}
