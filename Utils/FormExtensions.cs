namespace Utils;

public static class FormExtensions
{
    public static bool IsDisposingOrDisposed(this Form form)
    {
        try
        {
            return form.Invoke(delegate
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
