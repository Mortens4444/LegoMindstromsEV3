using System;
using System.IO;

namespace Mindstorms.Core.FileWriter
{
    public class FileStreamWriter : IWriter, IDisposable
    {
        private readonly FileStream fileStream;
        private bool disposed;

        public FileStreamWriter(string destinationFilePath)
        {
            fileStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write);
        }

        ~FileStreamWriter()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                fileStream.Close();
            }
            disposed = true;
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            fileStream.Write(buffer, offset, count);
            fileStream.Flush();
        }
    }
}
