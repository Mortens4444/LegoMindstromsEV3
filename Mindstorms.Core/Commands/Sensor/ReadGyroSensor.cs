using Mindstorms.Core.Commands.Sensor;
using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class ReadGyroSensor : SensorRead
    {
        public ReadGyroSensor(SensorPort sensorPort, GyroSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
        {
            data = GetData((byte)sensorPort, (byte)SensorType.Gyro, (byte)sensorMode, InputSubCode.ReadyRaw, daisyChainLayer);
        }
    }
}
