using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Mindstorms.Controller.SensorRead
{
    public partial class InfraredSensorForm : Form
    {
        private readonly Brick brick;
        private bool readSensor;

        public InfraredSensorForm(Brick brick)
        {
            InitializeComponent();
            this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);

            cbDaisyChainLayer.FillAndSelectFirst(DaisyChainLayer.GetValues());
            cbSensorPort.FillAndSelect(SensorPort.GetValues(), SensorPort.In4);
            cbSensorMode.FillAndSelect(InfraredSensorMode.GetValues(), InfraredSensorMode.InfraredRemoteMode);
        }

        private void BtnStartStopRead_Click(object sender, EventArgs e)
        {
            cbSensorMode.Enabled = readSensor;
            readSensor = !readSensor;
            if (readSensor)
            {
                var sensorPort = (SensorPort)cbSensorPort.SelectedItem;
                var sensorMode = (InfraredSensorMode)cbSensorMode.SelectedItem;
                btnStartStopRead.Text = "Stop";

                Task.Factory.StartNew(() =>
                {
                    while (readSensor)
                    {
                        var result = brick.ReadInfraredSensor(sensorPort, sensorMode, (DaisyChainLayer)cbDaisyChainLayer.SelectedItem);
                        if (!this.IsDisposingOrDisposed())
                        {
                            Invoke(new Action(() =>
                            {
                                var distance = BitConverter.ToSingle(result, result.Length - 4);
                                label1.Text = ((InfraredBeaconButtonsCombination)Convert.ToInt32(distance)).ToString();
                                label2.Text = ((InfraredBeaconButtonsCombination)result[4]).ToString();
                                label3.Text = ((InfraredBeaconButtonsCombination)result[5]).ToString();
                                label4.Text = ((InfraredBeaconButtonsCombination)result[6]).ToString();

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
