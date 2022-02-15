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

            var sensorPort = brick.GetSensor(SensorType.NXTTouch);
            cbSensorPort.FillAndSelect(Enum.GetValues(typeof(SensorPort)), (byte)sensorPort);
            cbSensorMode.FillAndSelect(Enum.GetValues(typeof(TouchSensorMode)), (byte)TouchSensorMode.Touch);
        }

        private void BtnStartStopRead_Click(object sender, EventArgs e)
        {
            if (!readSensor)
            {
                var sensorPort = (SensorPort)cbSensorPort.SelectedItem;
                var sensorMode = (TouchSensorMode)cbSensorMode.SelectedItem;
                readSensor = true;
                btnStartStopRead.Text = "Stop";

                Task.Factory.StartNew(() =>
                {
                    while (readSensor)
                    {
                        var result = brick.ReadTouchSensor(sensorPort, sensorMode);
                        if (!this.IsDisposingOrDisposed())
                        {
                            Invoke(new Action(() =>
                            {
                                var value = BitConverter.ToSingle(result, result.Length - 4);
                                if (sensorMode == TouchSensorMode.Touch)
                                {
                                    var pressed = value != 0;
                                    lblResult.Text = pressed ? "Pressed" : "Released";
                                }
                                else
                                {
                                    lblResult.Text = $"Bump count: {value}";
                                }
                                lblResult.Text += $"{Environment.NewLine}Raw data: {String.Join(" ", result)}";
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

        private void TouchSensorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            readSensor = false;
        }
    }
}
