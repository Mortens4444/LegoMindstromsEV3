using System;

namespace SpeechRecognition
{
    public class VoiceCommand
    {
        public string Command { get; }

        public Action Action { get; }

        public VoiceCommand(string command, Action action)
        {
            Command = command;
            Action = action;
        }
    }
}
