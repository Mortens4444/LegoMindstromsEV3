using Mindstorms.Core.Drawing;
using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Utils;

namespace Mindstorms.Controller
{
    public partial class ScreenForm : Form
    {
        private readonly Brick brick;
        private EV3Point startPoint;
        private List<IEV3DrawingElement> objectsToDraw = new List<IEV3DrawingElement>();
        private IEV3DrawingElement temporaryElementToDraw;

        public ScreenForm(Brick brick)
        {
            InitializeComponent();
            this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);
            cbLedPattern.ComboBox.FillAndSelect(Enum.GetValues(typeof(LedPattern)), (byte)LedPattern.Off);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            brick.ClearScreen();
            objectsToDraw = new List<IEV3DrawingElement>();
            pDisplay.Invalidate();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            brick.UpdateScreen();
        }

        private void Display_Paint(object sender, PaintEventArgs e)
        {
            foreach (var objectToDraw in objectsToDraw)
            {
                objectToDraw.DrawOnGraphics(e.Graphics);
            }
            temporaryElementToDraw?.DrawOnGraphics(e.Graphics);

            pDisplay.Update();
        }

        private void RbText_CheckedChanged(object sender, EventArgs e)
        {
            tbText.Enabled = rbText.Checked;
        }

        private void Display_MouseDown(object sender, MouseEventArgs e)
        {
            var point = new EV3Point((byte)e.X, (byte)e.Y);
            if (rbPixel.Checked)
            {
                objectsToDraw.Add(point);
                brick.PutPixel(point);
            }
            else if (rbText.Checked)
            {
                if (tbText.Text != String.Empty)
                {
                    var text = new EV3Text(point, tbText.Text);
                    objectsToDraw.Add(text);
                    brick.DrawString(text);
                }
            }
            else
            {
                startPoint = point;
            }
        }

        private void Display_MouseUp(object sender, MouseEventArgs e)
        {
            var element = GetEV3DrawingElement(e);
            if (element != null)
            {
                objectsToDraw.Add(element);
                brick.Draw(element, LCDColor.Black, chkFill.Checked);
            }
            startPoint = null;
            pDisplay.Invalidate();
        }

        private IEV3DrawingElement GetEV3DrawingElement(MouseEventArgs e)
        {
            if (rbLine.Checked)
            {
                return new EV3Line(startPoint.X, startPoint.Y, (byte)e.X, (byte)e.Y);
            }
            else if (rbCircle.Checked)
            {
                return new EV3Circle(startPoint.X, startPoint.Y, (byte)e.X, (byte)e.Y, chkFill.Checked);
            }
            else if (rbRectangle.Checked)
            {
                var width = (byte)Math.Abs(e.X - startPoint.X);
                var height = (byte)Math.Abs(e.Y - startPoint.Y);
                return new EV3Rectangle(startPoint, width, height, chkFill.Checked);
            }
            else if (rbInverseRectangle.Checked)
            {
                var width = (byte)Math.Abs(e.X - startPoint.X);
                var height = (byte)Math.Abs(e.Y - startPoint.Y);
                return new EV3InverseRectangle(startPoint, width, height, pDisplay);
            }

            return null;
        }

        private void Display_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPoint != null)
            {
                temporaryElementToDraw = GetEV3DrawingElement(e);
                pDisplay.Invalidate();
            }
            else
            {
                temporaryElementToDraw = null;
            }
        }

        private void BtnSetLedsState_Click(object sender, EventArgs e)
        {
            brick.ChangeLedsState((LedPattern)cbLedPattern.SelectedItem);
        }
    }
}
