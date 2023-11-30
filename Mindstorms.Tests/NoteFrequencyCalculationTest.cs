using Mindstorms.Core.Music;
using Mindstorms.Core.Music.Notes;

namespace Mindstorms.Tests;

public class NoteFrequencyCalculationTests
{
    private static readonly Dictionary<Note, double> expectations = new()
    {
        { new A4(), 440 },
        { new C4(), 261.62556530059851 }
    };

    [Test]
    public void TestNoteFrequencies()
    {
        foreach (var expectation in expectations)
        {
            Assert.That(expectation.Key.Frequency, Is.EqualTo(expectation.Value));
        }
    }
}