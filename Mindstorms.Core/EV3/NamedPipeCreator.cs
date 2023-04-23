using System.Runtime.InteropServices;

namespace Mindstorms.Core.EV3;

public class NamedPipeCreator
{
    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool CloseHandle(IntPtr hObject);

    [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    private static extern IntPtr CreateNamedPipe(
        string lpName,
        uint dwOpenMode,
        uint dwPipeMode,
        uint nMaxInstances,
        uint nOutBufferSize,
        uint nInBufferSize,
        uint nDefaultTimeOut,
        IntPtr lpSecurityAttributes);

    private const uint PIPE_ACCESS_DUPLEX = 0x00000003;
    private const uint PIPE_TYPE_BYTE = 0x00000000;
    private const uint PIPE_READMODE_BYTE = 0x00000000;
    private const uint PIPE_WAIT = 0x00000000;
    private const uint PIPE_UNLIMITED_INSTANCES = 255;

    public static IntPtr CreatePipe(string pipeName)
    {
        string fullPipeName = $"\\\\.\\pipe\\{pipeName}";
        IntPtr pipeHandle = CreateNamedPipe(
            fullPipeName,
            PIPE_ACCESS_DUPLEX,
            PIPE_TYPE_BYTE | PIPE_READMODE_BYTE | PIPE_WAIT,
            PIPE_UNLIMITED_INSTANCES,
            4096, // Output buffer size
            4096, // Input buffer size
            0,    // Default timeout
            IntPtr.Zero);

        if (pipeHandle == new IntPtr(-1))
        {
            int error = Marshal.GetLastWin32Error();
            Console.WriteLine($"Failed to create named pipe. Error: {error}");
        }
        else
        {
            Console.WriteLine($"Named pipe created successfully: {fullPipeName}");
        }

        return pipeHandle;
    }

    public static void ClosePipe(IntPtr pipeHandle)
    {
        if (pipeHandle != IntPtr.Zero)
        {
            if (CloseHandle(pipeHandle))
            {
                Console.WriteLine("Named pipe handle closed successfully.");
            }
            else
            {
                int error = Marshal.GetLastWin32Error();
                Console.WriteLine($"Failed to close named pipe handle. Error: {error}");
            }
        }
    }
}
