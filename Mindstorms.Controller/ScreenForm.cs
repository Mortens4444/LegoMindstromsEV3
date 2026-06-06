using Mtf.Drawing.Geometry;
using Mtf.Drawing.Interfaces;
using Mtf.Drawing.Render;
using Mtf.Extensions;
using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.EV3;

namespace Mindstorms.Controller;

public partial class ScreenForm : Form
{
    private readonly Brick brick;
    private PointPrimitive? startPoint;
    private List<IPrimitive> objectsToDraw = [];
    private IPrimitive? temporaryElementToDraw;

    public ScreenForm(Brick? brick)
    {
        InitializeComponent();
        this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);
        cbLedPattern.ComboBox.FillAndSelect(LedPattern.GetValues(), LedPattern.Off);
        cbEmbeddedImages.FillAndSelectFirst(Enum.GetValues(typeof(EmbeddedImage)));
    }

    private void BtnClear_Click(object sender, EventArgs e)
    {
        brick.ClearScreen();
        objectsToDraw = [];
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
        var point = new PointPrimitive((byte)e.X, (byte)e.Y);
        if (rbPixel.Checked)
        {
            objectsToDraw.Add(point);
            brick.PutPixel(point, LCDColor.Black);
        }
        else if (rbText.Checked)
        {
            if (tbText.Text != String.Empty)
            {
                var text = new TextPrimitive(point, tbText.Text);
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
            brick.Draw(element, LCDColor.Black);
        }
        startPoint = null;
        pDisplay.Invalidate();
    }

    private IPrimitive? GetEV3DrawingElement(MouseEventArgs e)
    {
        if (startPoint != null)
        {
            if (rbLine.Checked)
            {
                return new LinePrimitive { Line = new LineF(new PointF(startPoint.ShapeData.Center.X, startPoint.ShapeData.Center.Y), new PointF((byte)e.X, (byte)e.Y)) };
            }
            else if (rbCircle.Checked)
            {
                return new CirclePrimitive { Center = new PointF(startPoint.ShapeData.Center.X, startPoint.ShapeData.Center.Y), Radius = (byte)Math.Abs(e.X - startPoint.Shape.Center.X), Fill = chkFill.Checked };
            }
            else if (rbRectangle.Checked)
            {
                var width = (byte)Math.Abs(e.X - startPoint.Shape.Center.X);
                var height = (byte)Math.Abs(e.Y - startPoint.Shape.Center.Y);
                return new EllipsePrimitive { Ellipse = new EllipseF(startPoint.Shape.Center, width, height), Fill = chkFill.Checked };
            }
            else if (rbInverseRectangle.Checked)
            {
                var width = (byte)Math.Abs(e.X - startPoint.Shape.Center.X);
                var height = (byte)Math.Abs(e.Y - startPoint.Shape.Center.Y);
                return new InverseRectanglePrimitive { Rect = new RectF(startPoint.Shape.Center.X, startPoint.Shape.Center.Y, width, height) };
            }
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
        brick.ChangeLEDsState((LedPattern)cbLedPattern.SelectedItem);
    }

    private void BtnShow_Click(object sender, EventArgs e)
    {
        brick.ShowImage((EmbeddedImage)cbEmbeddedImages.SelectedItem);
    }
}
