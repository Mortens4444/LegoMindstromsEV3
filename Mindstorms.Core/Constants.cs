using System.Text;

namespace Mindstorms.Core
{
    public static class Constants
    {
        public const ushort ChunkSize = 900;

        public const byte DefaultResponseLength = 32;

        public const byte DefaultStringLength = 63;

        public const ushort DefaultNoteDurationMs = 500;

        public static readonly Encoding DefaultEncoding = Encoding.ASCII;

        public const string GraphicsFileExtension = ".rgf";

        public const string SoundFileExtension = ".rsf";

        public const string BinaryFileExtension = ".rbf";

        public const int ReadWriteTimeout = 10000;
    }
}
