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

        public InfraredSensorForm(Brick? brick)
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
            cbDaisyChainLayer.Enabled = readSensor;
            readSensor = !readSensor;
            if (readSensor)
            {
                var sensorPort = (SensorPort)cbSensorPort.SelectedItem;
                var sensorMode = (InfraredSensorMode)cbSensorMode.SelectedItem;
                var daisyChainLayer = (DaisyChainLayer)cbDaisyChainLayer.SelectedItem;
                btnStartStopRead.Text = "Stop";

                Task.Factory.StartNew(() =>
                {
                    while (readSensor)
                    {
                        var result = brick.ReadInfraredSensor(sensorPort, sensorMode, daisyChainLayer);
                        if (!this.IsDisposingOrDisposed())
                        {
                            Invoke(new Action(() =>
                            {
                                lblRawResult.Text = result.ToString();

                                if (sensorMode == InfraredSensorMode.ProximityMode)
                                {
                                    var disctanceInCm = 0.7 * result;
                                    lblResult.Text = $"Distance (cm): {disctanceInCm}{Environment.NewLine}Raw data: {String.Join(" ", result)}";
                                }
                                else if (sensorMode == InfraredSensorMode.InfraredSeekerMode)
                                {
                                    var disctanceInCm = 2 * result;
                                    int direction = 0; // (-25) - 25
                                    lblResult.Text = $"Distance (cm): {disctanceInCm}{Environment.NewLine}Direction: {direction}{Environment.NewLine}Raw data: {String.Join(" ", result)}";
                                }
                                else
                                {
                                    lblResult.Text = $"Raw data: {String.Join(" ", result)}";
                                }                                
                            }));
                        }
                        Thread.Sleep(300);
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
