using Mindstorms.Core.Commands.Sensor;
using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor;

public class ReadGyroSensor : SensorRead
{
    public ReadGyroSensor(SensorPort sensorPort, GyroSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        data = GetData(sensorPort, SensorType.Gyro, sensorMode, InputSubCode.ReadyRaw, daisyChainLayer);
    }
}
