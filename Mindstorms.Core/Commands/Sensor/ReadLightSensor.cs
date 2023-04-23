using Mindstorms.Core.Commands.Sensor;
using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor;

public class ReadLightSensor : SensorRead
{
    public ReadLightSensor(SensorPort sensorPort, LightSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        data = GetData(sensorPort, SensorType.Color, sensorMode, InputSubCode.ReadySI, daisyChainLayer);
    }
}
