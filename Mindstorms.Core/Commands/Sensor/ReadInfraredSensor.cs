using Mindstorms.Core.Enums;

namespace Mindstorms.Core.Commands.Motor
{
    public class ReadInfraredSensor : SensorCommand
    {
        public ReadInfraredSensor(SensorPort sensorPort, InfraredSensorMode sensorMode)
        {
            data = GetData((byte)sensorPort, (byte)SensorType.IR, (byte)sensorMode);
        }
    }
}
