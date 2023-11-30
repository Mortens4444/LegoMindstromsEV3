using Mindstorms.Core.Music.Notes;

namespace Mindstorms.Tests;

public class NoteFrequencyCalculationTests
{
    [Test]
    public void TestNote()
    {
        var a4 = new A4();            
        Assert.That(a4.Frequency, Is.EqualTo(440));
    }
}