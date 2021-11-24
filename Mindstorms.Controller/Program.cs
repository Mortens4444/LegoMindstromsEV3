using MessageBoxes;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Mindstorms.Controller
{
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
#if DEBUG
                ErrorBox.Show(e.ExceptionObject as Exception);
#else
                ErrorBox.Show("Unhandled exception", (e.ExceptionObject as Exception).Message);
#endif
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
#if DEBUG
                ErrorBox.Show(e.Exception);
#else
                ErrorBox.Show("Unhandled exception", e.Exception.Message);
#endif
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
        }
    }
}
