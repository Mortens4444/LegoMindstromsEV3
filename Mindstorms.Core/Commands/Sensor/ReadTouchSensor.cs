using Mindstorms.Core.Commands.Sensor;
using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class ReadTouchSensor : SensorRead
    {
        public ReadTouchSensor(SensorPort sensorPort, TouchSensorMode sensorMode)
        {
            data = GetData((byte)sensorPort, (byte)SensorType.Touch, (byte)sensorMode, InputSubCode.ReadySI);
        }
    }
}
