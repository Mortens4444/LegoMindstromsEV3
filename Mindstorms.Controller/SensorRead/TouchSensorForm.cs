using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Mindstorms.Controller.SensorRead
{
    public partial class TouchSensorForm : Form
    {
        private readonly Brick brick;
        private bool readSensor;

        public TouchSensorForm(Brick brick)
        {
            InitializeComponent();
            this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);

            cbDaisyChainLayer.FillAndSelectFirst(DaisyChainLayer.GetValues());
            var sensorPort = brick.GetSensor(SensorType.NXTTouch, (DaisyChainLayer)cbDaisyChainLayer.SelectedItem);
            cbSensorPort.FillAndSelect(SensorPort.GetValues(), sensorPort);
            cbSensorMode.FillAndSelect(TouchSensorMode.GetValues(), TouchSensorMode.Touch);
        }

        private void BtnStartStopRead_Click(object sender, EventArgs e)
        {
            cbSensorMode.Enabled = readSensor;
            cbDaisyChainLayer.Enabled = readSensor;
            readSensor = !readSensor;
            if (readSensor)
            {
                var sensorPort = (SensorPort)cbSensorPort.SelectedItem;
                var sensorMode = (TouchSensorMode)cbSensorMode.SelectedItem;
                var daisyChainLayer = (DaisyChainLayer)cbDaisyChainLayer.SelectedItem;
                btnStartStopRead.Text = "Stop";

                Task.Factory.StartNew(() =>
                {
                    while (readSensor)
                    {
                        var result = brick.ReadTouchSensor(sensorPort, sensorMode, daisyChainLayer);
                        if (!this.IsDisposingOrDisposed())
                        {
                            Invoke(new Action(() =>
                            {
                                if (sensorMode == TouchSensorMode.Touch)
                                {
                                    var pressed = result != 0;
                                    lblResult.Text = pressed ? "Pressed" : "Released";
                                }
                                else
                                {
                                    lblResult.Text = $"Bump count: {result}";
                                }
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

        private void TouchSensorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            readSensor = false;
        }
    }
}
