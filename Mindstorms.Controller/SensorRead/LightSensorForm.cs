using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Mindstorms.Controller.SensorRead
{
    public partial class LightSensorForm : Form
    {
        private readonly Brick brick;
        private bool readSensor;

        public LightSensorForm(Brick? brick)
        {
            InitializeComponent();
            this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);

            cbDaisyChainLayer.FillAndSelectFirst(DaisyChainLayer.GetValues());
            var sensorPort = brick.GetSensor(SensorType.NXTLight, (DaisyChainLayer)cbDaisyChainLayer.SelectedItem);
            cbSensorPort.FillAndSelect(SensorPort.GetValues(), sensorPort);
            cbSensorMode.FillAndSelect(LightSensorMode.GetValues(), LightSensorMode.MeasuringColors);
        }

        private void BtnStartStopRead_Click(object sender, EventArgs e)
        {
            cbSensorMode.Enabled = readSensor;
            cbDaisyChainLayer.Enabled = readSensor;
            readSensor = !readSensor;
            if (readSensor)
            {
                var sensorPort = (SensorPort)cbSensorPort.SelectedItem;
                var sensorMode = (LightSensorMode)cbSensorMode.SelectedItem;
                var daisyChainLayer = (DaisyChainLayer)cbDaisyChainLayer.SelectedItem;
                btnStartStopRead.Text = "Stop";

                Task.Factory.StartNew(() =>
                {
                    while (readSensor)
                    {
                        var result = brick.ReadLightSensor(sensorPort, sensorMode, daisyChainLayer);
                        if (!this.IsDisposingOrDisposed())
                        {
                            Invoke(new Action(() =>
                            {
                                var text = sensorMode == LightSensorMode.MeasuringColors ? ((SensorColor)result).ToString() : result.ToString();
                                lblResult.Text = $"{sensorMode}: {text}";
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

        private void LightSensorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            readSensor = false;
        }

        private void BtnFollowLine_Click(object sender, EventArgs e)
        {
            brick.FollowLine((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, (SensorPort)cbSensorPort.SelectedItem);
        }
    }
}
