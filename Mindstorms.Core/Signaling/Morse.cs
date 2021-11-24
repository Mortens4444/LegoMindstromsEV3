using Mindstorms.Core.Commands.Speaker;
using Mindstorms.Core.Enums;
using System;
using System.Linq;
using System.Threading;

namespace Mindstorms.Core.Signaling
{
    public class Morse
    {
        private readonly Brick brick;

        private const char Space = ' ';
        private const int MorseFrequency = 3000;
        private const LedPattern ledPattern = LedPattern.Green;

        public Morse(Brick brick, ushort shortMorseUnit = 50)
        {
            this.brick = brick ?? throw new ArgumentNullException(nameof(brick));
            ShortMorseUnit = shortMorseUnit;
            brick.ChangeLedsState(LedPattern.Off);
        }

        public ushort ShortMorseUnit { get; }

        public ushort LongMorseUnit => (ushort)(ShortMorseUnit * 3);

        public ushort WaitBetweenCharacters => (ushort)(ShortMorseUnit * 3);

        public ushort WaitBetweenWords => (ushort)(ShortMorseUnit * 7);

        public void Di()
        {
            Signal(ShortMorseUnit);
        }

        public void Dah()
        {
            Signal(LongMorseUnit);
        }

        public void DeleteLastWord()
        {
            for (int i = 0; i < 8; i++)
            {
                Di();
                Thread.Sleep(ShortMorseUnit);
            }
        }

        public void Text(string text)
        {
            var words = text.Split(' ');
            var wordPicker = words.GetEnumerator();
            var word = wordPicker.MoveNext() ? (string)wordPicker.Current : String.Empty;

            foreach (var character in text)
            {
                if (character == Space)
                {
                    word = wordPicker.MoveNext() ? (string)wordPicker.Current : String.Empty;
                }

                brick.ClearScreen();
                brick.DrawString(85, 60, character.ToString(), Color.Black, FontType.Big);
                brick.DrawString(10, 80, word, Color.Black, FontType.Big);
                brick.UpdateScreen();

                Thread.Sleep(character == Space ? WaitBetweenWords : WaitBetweenCharacters);
                Signal(GetCharacterMorseCode(character));
            }

            brick.ClearScreen();
            brick.UpdateScreen();
        }

        private void Signal(ushort duration)
        {
            brick.ChangeLedsState(ledPattern);
            brick.BeepAndWait(Beep.DefaultVolume, MorseFrequency, duration);
            brick.ChangeLedsState(LedPattern.Off);
        }

        private MorseCode GetCharacterMorseCode(char ch)
        {
            return Codes.MorseCodes.FirstOrDefault(code => code.Character == Char.ToUpper(ch));
        }

        private void Signal(MorseCode morse)
        {
            if (morse != null)
            {
                foreach (var signal in morse.Signals)
                {
                    if (signal == Signaling.Signal.Di)
                    {
                        Di();
                    }
                    else
                    {
                        Dah();
                    }
                    Thread.Sleep(ShortMorseUnit);
                }
            }
        }
    }
}
