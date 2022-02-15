﻿using Mindstorms.Core.Enums;
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

            var sensorPort = brick.GetSensor(SensorType.NXTLight);
            cbSensorPort.FillAndSelect(Enum.GetValues(typeof(SensorPort)), (byte)sensorPort);
            cbSensorMode.FillAndSelect(Enum.GetValues(typeof(LightSensorMode)), (byte)LightSensorMode.MeasuringColors);
        }

        private void BtnStartStopRead_Click(object sender, EventArgs e)
        {
            if (!readSensor)
            {
                var sensorPort = (SensorPort)cbSensorPort.SelectedItem;
                var sensorMode = (LightSensorMode)cbSensorMode.SelectedItem;
                readSensor = true;
                btnStartStopRead.Text = "Stop";

                Task.Factory.StartNew(() =>
                {
                    while (readSensor)
                    {
                        var result = brick.ReadLightSensor(sensorPort, sensorMode);
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
