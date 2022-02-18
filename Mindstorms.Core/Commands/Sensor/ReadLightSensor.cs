using Mindstorms.Core.Commands.Sensor;
using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class ReadLightSensor : SensorCommand
    {
        public ReadLightSensor(SensorPort sensorPort, LightSensorMode sensorMode)
        {
            data = GetData((byte)sensorPort, (byte)SensorType.Color, (byte)sensorMode, InputSubCode.ReadySI);
        }
    }
}
