using Mindstorms.Core;
using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Mindstorms.Controller
{
    public partial class MotorForm : Form
    {
        private readonly Brick brick;

        public MotorForm(Brick brick)
        {
            InitializeComponent();
            this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);

            cbDaisyChainLayer.FillAndSelectFirst(DaisyChainLayer.GetValues());

            RefreshPositions();
        }

        private void SetMotorSpeed(short acceleration, params SetMotorSpeedParams[] motorSpeedChanges)
        {
            foreach (var motorSpeedChange in motorSpeedChanges)
            {
                if (acceleration != 0)
                {
                    if (motorSpeedChange.Speed < 0)
                    {
                        for (short currentSpeed = 0; currentSpeed >= motorSpeedChange.Speed; currentSpeed -= acceleration)
                        {
                            brick.SetLargeMotorSpeed((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, motorSpeedChange);
                            Thread.Sleep(100);
                        }
                    }
                    else
                    {
                        for (short currentSpeed = 0; currentSpeed <= motorSpeedChange.Speed; currentSpeed += acceleration)
                        {
                            brick.SetLargeMotorSpeed((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, motorSpeedChange);
                            Thread.Sleep(100);
                        }
                    }
                }
                brick.SetLargeMotorSpeed((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, motorSpeedChange);
                StopMotorsWithDelay();
            }
        }

        private void BtnSetLeftMotorSpeed_Click(object sender, EventArgs e)
        {
            SetMotorSpeed(chkAccelerate.Checked ? (short)tbAccelerate.Value : (short)0, new SetMotorSpeedParams(brick.LeftMotor, (short)tbLeftSpeed.Value));
        }

        private void BtnSetRightMotorSpeed_Click(object sender, EventArgs e)
        {
            SetMotorSpeed(chkAccelerate.Checked ? (short)tbAccelerate.Value : (short)0, new SetMotorSpeedParams(brick.RightMotor, (short)tbRightSpeed.Value));
        }

        private void BtnSetBothMotorSpeed_Click(object sender, EventArgs e)
        {
            SetMotorSpeed(chkAccelerate.Checked ? (short)tbAccelerate.Value : (short)0, new SetMotorSpeedParams(brick.LeftMotor, (short)tbLeftSpeed.Value), new SetMotorSpeedParams(brick.RightMotor, (short)tbRightSpeed.Value));
        }

        private void StopMotorsWithDelay()
        {
            if (chkTimeout.Checked)
            {
                var timeout = (double)nudTimeout.Value;
                var daisyChainLayer = (DaisyChainLayer)cbDaisyChainLayer.SelectedItem;
                Task.Run(async delegate
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(timeout));
                    brick.SetLargeMotorSpeed(daisyChainLayer, new SetMotorSpeedParams(brick.Motors, 0));
                });
            }
        }

        private void BtnSetLeverMotorSpeed_Click(object sender, EventArgs e)
        {
            brick.SetMediumMotorSpeed((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, new SetMotorSpeedParams(brick.LeverMotor, (short)tbLeverSpeed.Value));
        }

        private void BtnRefreshPositions_Click(object sender, EventArgs e)
        {
            RefreshPositions();
        }

        private void RefreshPositions()
        {
            lblLeftMotorPosition.Text = String.Join(", ", brick.GetMotorPosition(brick.LeftMotor, MotorType.Large, (DaisyChainLayer)cbDaisyChainLayer.SelectedItem));
            lblRightMotorPosition.Text = String.Join(", ", brick.GetMotorPosition(brick.RightMotor, MotorType.Large, (DaisyChainLayer)cbDaisyChainLayer.SelectedItem));
            lblLeverMotorPosition.Text = String.Join(", ", brick.GetMotorPosition(brick.LeverMotor, MotorType.Medium, (DaisyChainLayer)cbDaisyChainLayer.SelectedItem));
        }
    }
}
