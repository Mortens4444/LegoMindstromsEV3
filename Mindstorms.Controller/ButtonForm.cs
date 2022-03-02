using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using Color = System.Drawing.Color;

namespace Mindstorms.Controller
{
    public partial class ButtonForm : Form
    {
        private readonly Brick brick;

        public ButtonForm(Brick brick)
        {
            InitializeComponent();
            this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);
        }

        private void ButtonForm_Shown(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    while (!this.IsDisposingOrDisposed())
                    {
                        var buttonStates = brick.GetButtonStates();
                    
                        Invoke(new Action(() => {
                            lblButtonStates.Text = buttonStates.ToString();
                            btnBack.BackColor = buttonStates.IsBackButtonPressed() ? Color.Green : Color.WhiteSmoke;
                            btnUp.BackColor = buttonStates.IsUpButtonPressed() ? Color.Green : Color.WhiteSmoke;
                            btnCenter.BackColor = buttonStates.IsCenterButtonPressed() ? Color.Green : Color.WhiteSmoke;
                            btnDown.BackColor = buttonStates.IsDownButtonPressed() ? Color.Green : Color.WhiteSmoke;
                            btnRight.BackColor = buttonStates.IsRightButtonPressed() ? Color.Green : Color.WhiteSmoke;
                            btnLeft.BackColor = buttonStates.IsLeftButtonPressed() ? Color.Green : Color.WhiteSmoke;
                        }));
                    
                        Thread.Sleep(500);
                    }
                });
            }
            catch (ObjectDisposedException) { }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            brick.PressAndReleaseButton((ButtonType)button.TabIndex);
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            //var button = sender as Button;
            //brick.PressButton((ButtonType)button.TabIndex);
        }

        private void Btn_MouseUp(object sender, MouseEventArgs e)
        {
            //var button = sender as Button;
            //brick.ReleaseButton((ButtonType)button.TabIndex);
        }
    }
}
