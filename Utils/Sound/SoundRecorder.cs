using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace Utils.Sound
{
    public class SoundRecorder
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int mciSendStringA(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        private Guid guid = Guid.Empty;
        private string tempFile;
        private readonly Stopwatch stopwatch = new Stopwatch();

        public TimeSpan RecordingInterval => stopwatch.Elapsed;

        public void Record()
        {
            stopwatch.Restart();
            guid = Guid.NewGuid();
            mciSendStringA($"open new Type waveaudio Alias {guid}", String.Empty, 0, 0);
            mciSendStringA($"record {guid}", String.Empty, 0, 0);
        }

        public void StopRecording()
        {
            tempFile = Path.GetTempFileName();
            mciSendStringA($"save {guid} {tempFile}", String.Empty, 0, 0);
            mciSendStringA($"close {guid}", String.Empty, 0, 0);
            stopwatch.Stop();
            guid = Guid.Empty;
        }

        public bool IsRecording()
        {
            return guid != Guid.Empty;
        }

        public void SaveRecording(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            File.Move(tempFile, filePath);
        }
    }
}
