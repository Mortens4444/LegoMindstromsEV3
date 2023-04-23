using Mindstorms.Core.Commands.Sensor;
using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor;

public class ReadInfraredSensor : SensorRead
{
    public ReadInfraredSensor(SensorPort sensorPort, InfraredSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
    {
        data = GetData(sensorPort, SensorType.IR, sensorMode, InputSubCode.ReadyRaw, daisyChainLayer, 2);
    }
}
