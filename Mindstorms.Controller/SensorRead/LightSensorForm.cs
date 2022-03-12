﻿using Mindstorms.Core.Commands.Sensor;
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

        public LightSensorForm(Brick brick)
        {
            InitializeComponent();
            this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);

            cbDaisyChainLayer.FillAndSelectFirst(Enum.GetValues(typeof(DaisyChainLayer)));
            var sensorPort = brick.GetSensor(SensorType.NXTLight, (DaisyChainLayer)cbDaisyChainLayer.SelectedItem);
            cbSensorPort.FillAndSelect(Enum.GetValues(typeof(SensorPort)), (byte)sensorPort);
            cbSensorMode.FillAndSelect(Enum.GetValues(typeof(LightSensorMode)), (byte)LightSensorMode.MeasuringColors);
        }

        private void BtnStartStopRead_Click(object sender, EventArgs e)
        {
            cbSensorMode.Enabled = readSensor;
            readSensor = !readSensor;
            if (readSensor)
            {
                var sensorPort = (SensorPort)cbSensorPort.SelectedItem;
                var sensorMode = (LightSensorMode)cbSensorMode.SelectedItem;
                btnStartStopRead.Text = "Stop";

                Task.Factory.StartNew(() =>
                {
                    while (readSensor)
                    {
                        var result = brick.ReadLightSensor(sensorPort, sensorMode, (DaisyChainLayer)cbDaisyChainLayer.SelectedItem);
                        if (!this.IsDisposingOrDisposed())
                        {
                            Invoke(new Action(() =>
                            {
                                var value = BitConverter.ToSingle(result, result.Length - 4);
                                var text = sensorMode == LightSensorMode.MeasuringColors ? ((SensorColor)value).ToString() : value.ToString();
                                lblResult.Text = $"{sensorMode}: {text}{Environment.NewLine}Raw data: {String.Join(" ", result)}";
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
    }
}
