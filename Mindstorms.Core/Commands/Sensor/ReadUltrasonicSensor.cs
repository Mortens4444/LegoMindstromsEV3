using Mindstorms.Core.Commands.Sensor;
using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class ReadUltrasonicSensor : SensorCommand
    {
        public ReadUltrasonicSensor(SensorPort sensorPort, UltrasonicSensorMode sensorMode)
        {
            data = GetData((byte)sensorPort, (byte)SensorType.Ultrasonic, (byte)sensorMode, InputSubCode.ReadySI);
        }
    }
}
