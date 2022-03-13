using Mindstorms.Core.Commands.Sensor;
using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class ReadTouchSensor : SensorRead
    {
        public ReadTouchSensor(SensorPort sensorPort, TouchSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
        {
            data = GetData(sensorPort, SensorType.Touch, sensorMode, InputSubCode.ReadySI, daisyChainLayer);
        }
    }
}
