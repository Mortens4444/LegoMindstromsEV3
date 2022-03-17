using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic
{
    public class Ln : OneOperatorOperand
    {
        public Ln(float value)
            : base(value, MathSubCode.Ln)
        {
        }
    }
}
