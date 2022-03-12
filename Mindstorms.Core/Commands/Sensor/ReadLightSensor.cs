using Mindstorms.Core.Commands.Sensor;
using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class ReadLightSensor : SensorRead
    {
        public ReadLightSensor(SensorPort sensorPort, LightSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
        {
            data = GetData((byte)sensorPort, (byte)SensorType.Color, (byte)sensorMode, InputSubCode.ReadySI, daisyChainLayer);
        }
    }
}
