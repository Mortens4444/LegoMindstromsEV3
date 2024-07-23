using MessageBoxes;
using SourceInfo;

namespace Mindstorms.Controller;

static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }

    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        try
        {
            if (e.ExceptionObject is Exception exception)
            {
                ShowException(exception);
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
        }
    }

    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
        try
        {
            ShowException(e.Exception);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
        }
    }

    private static void ShowException(Exception exception)
    {
        var ex = new ExceptionDetails(exception);
        SaveToFile(ex.Details);

#if DEBUG
        ErrorBox.Show(exception);
#else
        ErrorBox.Show("Unhandled exception", exception.Message);
#endif
    }

    private static void SaveToFile(string message)
    {
        try
        {
            var directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ErrorMessages");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var timestamp = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            var fileName = $"{timestamp}_error.txt";
            var filePath = Path.Combine(directory, fileName);

            File.WriteAllText(filePath, message);
            InfoBox.Show("Save success", $"Message saved to file: {filePath}");
        }
        catch (Exception ex)
        {
            ErrorBox.Show("Save failed", $"Failed to save the message to file: {ex.Message}");
        }
    }
}
