using Mindstorms.Core.Commands.Sensor;
using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor;

public class ReadUltrasonicSensor : SensorRead
{
    public ReadUltrasonicSensor(SensorPort sensorPort, UltrasonicSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        data = GetData(sensorPort, SensorType.Ultrasonic, sensorMode, InputSubCode.ReadySI, daisyChainLayer);
    }
}
