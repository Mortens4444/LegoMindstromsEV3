using Mindstorms.Core;
using Mindstorms.Core.Enums;
using MindstormUtils;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using Color = System.Drawing.Color;
using Button = Mindstorms.Core.Enums.Button;

namespace Mindstorms.Controller
{
    public partial class ButtonForm : Form
    {
        private readonly Brick brick;

        public ButtonForm(Brick brick)
        {
            InitializeComponent();
            this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);
            cbButtonEvent.FillAndSelect(Enum.GetValues(typeof(ButtonEvent)), (byte)ButtonEvent.ShortPress - 1);
        }

        private void ButtonForm_Shown(object sender, EventArgs e)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    while (!this.IsDisposingOrDisposed())
                    {
                        var rawStates = brick.GetButtonStates();
                    
                        Invoke(new Action(() => {
                            lblButtonStates.Text = String.Join(", ", rawStates);

                            btnUp.BackColor = rawStates[5] != 0 ? Color.Green : Color.WhiteSmoke;
                            btnCenter.BackColor = rawStates[6] != 0 ? Color.Green : Color.WhiteSmoke;
                            btnDown.BackColor = rawStates[7] != 0 ? Color.Green : Color.WhiteSmoke;
                            btnLeft.BackColor = rawStates[8] != 0 ? Color.Green : Color.WhiteSmoke;
                            btnRight.BackColor = rawStates[9] != 0 ? Color.Green : Color.WhiteSmoke;
                        }));
                    
                        Thread.Sleep(100);
                    }
                });
            }
            catch (ObjectDisposedException) { }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            brick.PressButton((Button)button.TabIndex, (ButtonEvent)((byte)cbButtonEvent.SelectedItem - 1));
        }
    }
}
