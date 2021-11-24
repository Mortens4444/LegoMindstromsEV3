namespace Mindstorms.Core.Commands
{
    public abstract class AwaitableCommand : Command
    {
        public ushort DurationMs { get; }

        public AwaitableCommand(ushort durationMs)
        {
            DurationMs = durationMs;
        }
    }
}
