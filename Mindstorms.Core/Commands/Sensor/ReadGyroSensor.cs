using Mindstorms.Core.Commands.Sensor;
using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class ReadGyroSensor : SensorCommand
    {
        public ReadGyroSensor(SensorPort sensorPort, GyroSensorMode sensorMode)
        {
            data = GetData((byte)sensorPort, (byte)SensorType.Gyro, (byte)sensorMode, InputSubCode.ReadyRaw);
        }
    }
}
