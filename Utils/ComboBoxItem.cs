namespace Utils;

public class ComboBoxItem
{
    public object Object { get; }

    public ComboBoxItem(object @object)
    {
        Object = @object;
    }

    public override string ToString()
    {
        return Object.ToString()!;
    }
}
