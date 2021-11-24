using System;
using System.Windows.Forms;

namespace Utils
{
    public static class FormExtensions
    {
        public static bool IsDisposingOrDisposed(this Form form)
        {
            try
            {
                return (bool)form.Invoke((Func<bool>)delegate
                {
                    return form.Disposing || form.IsDisposed;
                });
            }
            catch
            {
                return true;
            }
        }
    }
}
