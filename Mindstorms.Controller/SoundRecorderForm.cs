using Utils.Sound;

namespace Mindstorms.Controller;

public partial class SoundRecorderForm : Form
{
    private readonly SoundRecorder soundRecorder = new();

    public SoundRecorderForm()
    {
        InitializeComponent();
        lblInterval.Text = new TimeSpan().ToString();
    }

    private void BtnRecordOrStop_Click(object sender, EventArgs e)
    {
        if (soundRecorder.IsRecording())
        {
            StopRecording();
        }
        else
        {
            StartRecording();
        }
    }

    private void StartRecording()
    {
        soundRecorder.Record();
        btnRecordOrStop.Text = "Stop";

        Task.Factory.StartNew(() =>
        {
            while (soundRecorder.IsRecording())
            {
                Invoke(new Action(() =>
                {
                    lblInterval.Text = soundRecorder.RecordingInterval.ToString();
                }));
                Thread.Sleep(100);
            }
        });
    }

    private void StopRecording()
    {
        soundRecorder.StopRecording();
        btnRecordOrStop.Text = "Record";

        if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
        {
            soundRecorder.SaveRecording(saveFileDialog.FileName);
        }
    }
}
