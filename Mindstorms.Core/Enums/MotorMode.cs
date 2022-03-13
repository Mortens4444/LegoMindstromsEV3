namespace Mindstorms.Core.Enums
{
    public class MotorMode : EnumLikeObject<MotorMode>
	{
		public static readonly MotorMode Degree = new MotorMode(0x00, nameof(Degree));
		public static readonly MotorMode Rotation = new MotorMode(0x01, nameof(Rotation));
		public static readonly MotorMode Power = new MotorMode(0x02, nameof(Power));

		private MotorMode(byte value, string name) : base(value, name)
		{
			Values.Add(value, this);
		}

		public static implicit operator MotorMode(byte value)
		{
			return Values[value];
		}

		public static implicit operator byte(MotorMode value)
		{
			return value.Value;
		}
	}
}
