using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using Mindstorms.Core.Music;
using Mindstorms.Core.Music.Melodies;
using System;
using System.Reflection;
using System.Windows.Forms;
using Utils;

namespace Mindstorms.Controller
{
    public partial class SpeakerForm : Form
    {
        private const string MelodiesNamespace = "Mindstorms.Core.Music.Melodies";
        private readonly Brick brick;

        public SpeakerForm(Brick brick)
        {
            InitializeComponent();
            this.brick = brick ?? throw new ArgumentNullException(nameof(brick), Constants.ConnectEV3Brick);

            var assembly = Assembly.GetAssembly(typeof(BociBoci));
            cbSounds.ComboBox.FillAndSelect(Enum.GetValues(typeof(EmbeddedSound)), (int)EmbeddedSound.EV3);
            cbMelodies.ComboBox.FillWithTypesInNamespace(assembly, MelodiesNamespace);
        }

        private void BtnBeep_Click(object sender, EventArgs e)
        {
            brick.Beep((byte)tbVolume.Value, (ushort)nudFrequecncy.Value, (ushort)nudDuration.Value);
        }

        private void BtnSilence_Click(object sender, EventArgs e)
        {
            brick.Silence();
        }

        private void BtnPlayMusic_Click(object sender, EventArgs e)
        {
            var melody = (Melody)((ComboBoxItem)cbMelodies.SelectedItem).Object;
            brick.PlayMusic(melody, (byte)tbVolume.Value);
        }

        private void BtnPlaySound_Click(object sender, EventArgs e)
        {
            brick.PlaySound((EmbeddedSound)cbSounds.SelectedItem, (byte)tbVolume.Value);
        }
    }
}
