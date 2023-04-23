using MessageBoxes;
using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using Mindstorms.Core.Resources;
using Utils;

namespace Mindstorms.Controller;

public partial class DeviceInfo : Form
{
    private readonly Brick brick;

    public DeviceInfo(Brick? brick)
    {
        InitializeComponent();
        this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);
    }

    private void SelectUsedCommunicationInterface(Brick brick, string deviceName)
    {
        int selectedIndex = 2;
        //int selectedIndex = 0;
        var comInterfaces = CommunicationInterface.GetValues();
        //for (int i = 1; i <= comInterfaces.Count; i++)
        //{
        //    if (brick.IsActive((CommunicationInterface)i, deviceName))
        //    {
        //        selectedIndex = i;
        //        break;
        //    }
        //}

        cbCommunicationInterface.FillAndSelect(comInterfaces, selectedIndex - 1);
    }

    private void DeviceInfo_Shown(object sender, EventArgs e)
    {
        tbName.Text = brick.GetBrickName();
        SelectUsedCommunicationInterface(brick, tbName.Text);
        if (tbName.Text == String.Empty)
        {
            throw new Exception("Unable to retrieve device name");
        }
        tbPin.Text = brick.GetPin((CommunicationInterface)cbCommunicationInterface.SelectedItem, tbName.Text);
        lblBatteryLevel.Text = $"Battery level: {brick.GetBatteryLevel():0.00} %";
        lblBatteryVoltage.Text = $"Battery voltage: {brick.GetBatteryVoltage():0.00} V";
        lblBatteryCurrent.Text = $"Battery current: {brick.GetBatteryCurrent():0.00} A";
        lblBatteryTemperatureRise.Text = $"Battery temperature rise: {brick.GetBatteryTemperatureRise():0.00} °C";
        lblOperatingSystemVersion.Text = $"Operating system version: {brick.GetOperatingSystemVersion()}";
        lblOperatingSystemBuild.Text = $"Operating system build: {brick.GetOperatingSystemBuild()}";
        lblFirmwareVersion.Text = $"Firmware version: {brick.GetFirmwareVersion()}";
        lblFirmwareBuild.Text = $"Firmware build: {brick.GetFirmwareBuild()}";
        lblHardwareVersion.Text = $"Hardware version: {brick.GetHardwareVersion()}";
        cbCommand.SelectedIndex = 0;
    }

    private void BtnChangeName_Click(object sender, EventArgs e)
    {
        brick.SetBrickName(tbName.Text);
    }

    private void BtnChangePin_Click(object sender, EventArgs e)
    {
        brick.SetPin((CommunicationInterface)cbCommunicationInterface.SelectedItem, tbName.Text, tbPin.Text);
    }

    private void BtnGetLastError_Click(object sender, EventArgs e)
    {
        var message = brick.GetLastError();
        if (message.StartsWith("0: "))
        {
            InfoBox.Show("Success", message);
        }
        else
        {
            ErrorBox.Show("Error", message);
        }
    }

    private void BtnExecute_Click(object sender, EventArgs e)
    {
        var destinationFile = $"{ResourceUploader.BaseDirectory}/output.rtf";
        brick.SystemCall(String.Concat(cbCommand.Text, $" > {destinationFile} 2>&1"));
        int fileSize = brick.GetSize(destinationFile);
        var stringWriter = new Core.FileWriter.StringWriter(fileSize);
        if (brick.CopyFileFromBrick(destinationFile, fileSize, stringWriter))
        {
            rtbCommandResult.Text = stringWriter.GetContent();
        }
    }
}
