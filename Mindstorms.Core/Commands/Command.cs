namespace Mindstorms.Core
{
    public abstract class Command
	{
        protected byte[] data;

        public byte[] Data
		{
            get { return data; }
        }

        public int Length
		{
            get { return data.Length; }
        }
    }
}
