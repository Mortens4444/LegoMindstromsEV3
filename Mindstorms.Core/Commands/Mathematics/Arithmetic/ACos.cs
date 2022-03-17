using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Mathematics.Arithmetic
{
    public class ACos : OneOperatorOperand
    {
        public ACos(float value)
            : base(value, MathSubCode.ACos)
        {
        }
    }
}
