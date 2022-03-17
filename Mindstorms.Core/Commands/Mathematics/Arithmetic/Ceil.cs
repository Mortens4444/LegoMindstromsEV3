using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic
{
    public class Ceil : OneOperatorOperand
    {
        public Ceil(float value)
            : base(value, MathSubCode.Ceil)
        {
        }
    }
}
