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

            cbDaisyChainLayer.FillAndSelectFirst(DaisyChainLayer.GetValues());
            cbSensorPort.FillAndSelect(SensorPort.GetValues(), SensorPort.In2);
            cbSensorMode.FillAndSelect(UltrasonicSensorMode.GetValues(), UltrasonicSensorMode.Cm);
        }

        private void BtnStartStopRead_Click(object sender, EventArgs e)
        {
            cbSensorMode.Enabled = readSensor;
            cbDaisyChainLayer.Enabled = readSensor;
            readSensor = !readSensor;
            if (readSensor)
            {
                var sensorPort = (SensorPort)cbSensorPort.SelectedItem;
                var sensorMode = (UltrasonicSensorMode)cbSensorMode.SelectedItem;
                var daisyChainLayer = (DaisyChainLayer)cbDaisyChainLayer.SelectedItem;
                btnStartStopRead.Text = "Stop";

                Task.Factory.StartNew(() =>
                {
                    while (readSensor)
                    {
                        var result = brick.ReadUltrasonicSensor(sensorPort, sensorMode, daisyChainLayer);
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
