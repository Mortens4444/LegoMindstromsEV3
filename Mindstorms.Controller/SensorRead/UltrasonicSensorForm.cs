using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Mindstorms.Controller.SensorRead
{
    public partial class UltrasonicSensorForm : Form
    {
        private readonly Brick brick;
        private bool readSensor;

        public UltrasonicSensorForm(Brick brick)
        {
            InitializeComponent();
            this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);

            cbDaisyChainLayer.FillAndSelectFirst(Enum.GetValues(typeof(DaisyChainLayer)));
            cbSensorPort.FillAndSelect(Enum.GetValues(typeof(SensorPort)), (byte)SensorPort.In2);
            cbSensorMode.FillAndSelect(Enum.GetValues(typeof(UltrasonicSensorMode)), (byte)UltrasonicSensorMode.Cm);
        }

        private void BtnStartStopRead_Click(object sender, EventArgs e)
        {
            cbSensorMode.Enabled = readSensor;
            readSensor = !readSensor;
            if (readSensor)
            {
                var sensorPort = (SensorPort)cbSensorPort.SelectedItem;
                var sensorMode = (UltrasonicSensorMode)cbSensorMode.SelectedItem;
                btnStartStopRead.Text = "Stop";

                Task.Factory.StartNew(() =>
                {
                    while (readSensor)
                    {
                        var result = brick.ReadUltrasonicSensor(sensorPort, sensorMode, (DaisyChainLayer)cbDaisyChainLayer.SelectedItem);
                        if (!this.IsDisposingOrDisposed())
                        {
                            Invoke(new Action(() =>
                            {
                                var distance = BitConverter.ToSingle(result, result.Length - 4);
                                lblResult.Text = $"Distance: {distance}{Environment.NewLine}Raw data: {String.Join(" ", result)}";
                            }));
                        }
                        Thread.Sleep(100);
                    }
                });
            }
            else
            {
                btnStartStopRead.Text = "Start";
                lblResult.Text = String.Empty;
                Update();
            }
        }

        private void UltrasonicSensorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            readSensor = false;
        }
    }
}
