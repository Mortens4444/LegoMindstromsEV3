using Mindstorms.Core.Commands.Sensor;
using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class ReadInfraredSensor : SensorRead
    {
        public ReadInfraredSensor(SensorPort sensorPort, InfraredSensorMode sensorMode, DaisyChainLayer daisyChainLayer)
        {
            data = GetData((byte)sensorPort, (byte)SensorType.IR, (byte)sensorMode, InputSubCode.ReadyRaw, daisyChainLayer);
        }
    }
}
