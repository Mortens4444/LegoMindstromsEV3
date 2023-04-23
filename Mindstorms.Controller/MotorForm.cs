using MessageBoxes;
using Mindstorms.Core;
using Mindstorms.Core.Commands.Motor;
using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using Utils;

namespace Mindstorms.Controller;

public partial class MotorForm : Form
{
    private readonly Brick brick;

    public MotorForm(Brick? brick)
    {
        InitializeComponent();
        this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);

        cbDaisyChainLayer.FillAndSelectFirst(DaisyChainLayer.GetValues());
        cbPolarity.FillAndSelectFirst(Polarity.GetValues());
        cbMotor.FillAndSelectFirst(OutputPort.GetNotCombinedValues());

        RefreshPositions();
    }

    private void SetMotorSpeed(sbyte acceleration, params SetMotorSpeedParams[] motorSpeedChanges)
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
        SetMotorSpeed(chkAccelerate.Checked ? (sbyte)tbAccelerate.Value : (sbyte)0, new SetMotorSpeedParams(brick.LeftMotor, (sbyte)tbLeftSpeed.Value));
    }

    private void BtnSetRightMotorSpeed_Click(object sender, EventArgs e)
    {
        SetMotorSpeed(chkAccelerate.Checked ? (sbyte)tbAccelerate.Value : (sbyte)0, new SetMotorSpeedParams(brick.RightMotor, (sbyte)tbRightSpeed.Value));
    }

    private void BtnSetBothMotorSpeed_Click(object sender, EventArgs e)
    {
        SetMotorSpeed(chkAccelerate.Checked ? (sbyte)tbAccelerate.Value : (sbyte)0, new SetMotorSpeedParams(brick.LeftMotor, (sbyte)tbLeftSpeed.Value), new SetMotorSpeedParams(brick.RightMotor, (sbyte)tbRightSpeed.Value));
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
        brick.SetMediumMotorSpeed((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, new SetMotorSpeedParams(brick.LeverMotor, (sbyte)tbLeverSpeed.Value));
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

    private void BtnSet_Click(object sender, EventArgs e)
    {
        brick.ChangeMotorPolarity((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, brick.Motors, (Polarity)cbPolarity.SelectedItem);
    }

    private void BtnClrTacho_Click(object sender, EventArgs e)
    {
        brick.Execute(new ClearTachoCount((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, brick.Motors));
    }

    private void BtnGetTacho_Click(object sender, EventArgs e)
    {
        var reply = brick.Execute(new GetTachoCount((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, brick.LeftMotor));
        var tachoCount = BitConverter.ToInt32(reply.RawResponseData, 3);
        lblLeftMotorPosition.Text = tachoCount.ToString();

        reply = brick.Execute(new GetTachoCount((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, brick.RightMotor));
        tachoCount = BitConverter.ToInt32(reply.RawResponseData, 3);
        lblRightMotorPosition.Text = tachoCount.ToString();
    }

    private void TbSpeed_ValueChanged(object sender, EventArgs e)
    {
        toolTip.SetToolTip((TrackBar)sender, $"{((TrackBar)sender).Value}%");
    }

    private void BtnCheckBusyness_Click(object sender, EventArgs e)
    {
        var busy = brick.MotorIsBusy((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, (OutputPort)cbMotor.SelectedItem);
        InfoBox.Show("Is motor busy", busy ? "The selected motor is busy" : "The selected motor is not busy");
    }

    private void BtnReset_Click(object sender, EventArgs e)
    {
        brick.ResetMotor((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, (OutputPort)cbMotor.SelectedItem);
    }

    private void BtnWaitForFinish_Click(object sender, EventArgs e)
    {
        brick.Execute(new WaitForFinish((DaisyChainLayer)cbDaisyChainLayer.SelectedItem, (OutputPort)cbMotor.SelectedItem));
    }
}
