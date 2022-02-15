using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using System;
using System.Windows.Forms;
using Utils;

namespace Mindstorms.Controller
{
    public partial class DeviceInfo : Form
    {
        private readonly Brick brick;

        public DeviceInfo(Brick brick)
        {
            InitializeComponent();
            this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);

            int selectedIndex = 2;// 0;
            var comInterfaces = Enum.GetValues(typeof(CommunicationInterface));
            //for (int i = 1; i <= comInterfaces.Length; i++)
            //{
            //    if (brick.IsActive((CommunicationInterface)i))
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
        }

        private void BtnChangeName_Click(object sender, EventArgs e)
        {
            brick.SetBrickName(tbName.Text);
        }

        private void BtnChangePin_Click(object sender, EventArgs e)
        {
            brick.SetPin((CommunicationInterface)cbCommunicationInterface.SelectedItem, tbName.Text, tbPin.Text);
        }
    }
}
