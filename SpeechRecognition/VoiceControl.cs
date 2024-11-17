using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;

namespace SpeechRecognition
{
    public static class VoiceControl
    {
        public static SpeechRecognitionEngine InitializeVoiceControl(IList<VoiceCommand> voiceCommands)
        {
            var recognizers = SpeechRecognitionEngine.InstalledRecognizers();
            if (recognizers.Count == 0)
            {
                return null;
            }

            var speechRecognitionEngine = new SpeechRecognitionEngine(recognizers[0].Culture);
            speechRecognitionEngine.SpeechRecognized += (object sender, SpeechRecognizedEventArgs e) =>
            {
                if (e.Result.Confidence > 0.75)
                {
                    var voiceCommand = voiceCommands.FirstOrDefault(vc => vc.Command == e.Result.Text);
                    voiceCommand?.Action();
                }
            };

            var words = new Choices();
            var commands = voiceCommands.Select(voiceCommand => voiceCommand.Command);
            foreach (var command in commands)
            {
                words.Add(command);
            }

            var grammarBuilder = new GrammarBuilder(words) { Culture = speechRecognitionEngine.RecognizerInfo.Culture };
            var grammar = new Grammar(grammarBuilder);
            speechRecognitionEngine.LoadGrammar(grammar);
            speechRecognitionEngine.SetInputToDefaultAudioDevice();
            speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
            return speechRecognitionEngine;
        }

        public static void StopVoiceControl(ref SpeechRecognitionEngine speechRecognitionEngine)
        {
            if (speechRecognitionEngine != null)
            {
                speechRecognitionEngine.RecognizeAsyncStop();
                speechRecognitionEngine = null;
            }
        }
    }
}

