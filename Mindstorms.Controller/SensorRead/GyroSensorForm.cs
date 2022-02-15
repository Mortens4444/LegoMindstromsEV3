using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Mindstorms.Controller.SensorRead
{
    public partial class GyroSensorForm : Form
    {
        private readonly Brick brick;
        private bool readSensor;

        public GyroSensorForm(Brick brick)
        {
            InitializeComponent();
            this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);

            cbSensorPort.FillAndSelect(Enum.GetValues(typeof(SensorPort)), (byte)SensorPort.In3);
            cbSensorMode.FillAndSelect(Enum.GetValues(typeof(GyroSensorMode)), (byte)GyroSensorMode.Angle);
        }

        private void BtnStartStopRead_Click(object sender, EventArgs e)
        {
            if (!readSensor)
            {
                var sensorPort = (SensorPort)cbSensorPort.SelectedItem;
                var sensorMode = (GyroSensorMode)cbSensorMode.SelectedItem;
                readSensor = true;
                btnStartStopRead.Text = "Stop";

                Task.Factory.StartNew(() =>
                {
                    while (readSensor)
                    {
                        var result = brick.ReadGyroSensor(sensorPort, sensorMode);
                        if (!this.IsDisposingOrDisposed())
                        {
                            Invoke(new Action(() =>
                            {
                                var value = BitConverter.ToSingle(result, result.Length - 4);
                                lblResult.Text = $"{sensorMode}: {value}{Environment.NewLine}Raw data: {String.Join(" ", result)}";
                            }));
                        }
                        Thread.Sleep(100);
                    }
                });
            }
            else
            {
                readSensor = false;
                btnStartStopRead.Text = "Start";
                lblResult.Text = String.Empty;
                Update();
            }
        }

        private void LightSensorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            readSensor = false;
        }
    }
}
