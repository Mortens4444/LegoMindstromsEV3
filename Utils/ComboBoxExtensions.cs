using System.Collections;
using System.Reflection;
using System.Windows.Forms;

namespace Utils
{
    public static class ComboBoxExtensions
    {
        public static void FillAndSelect(this ComboBox comboBox, IList list, int selectedIndex = 0)
        {
            comboBox.DataSource = list;
            SafeSelect(comboBox, selectedIndex);
        }

        public static void FillAndSelectFirst(this ComboBox comboBox, IList list)
        {
            FillAndSelect(comboBox, list, 0);
        }

        public static void FillAndSelectLast(this ComboBox comboBox, IList list)
        {
            FillAndSelect(comboBox, list, comboBox.Items.Count - 1);
        }

        public static void FillWithTypesInNamespace(this ComboBox comboBox, Assembly assembly, string @namespace)
        {
            comboBox.DataSource = assembly.GetTypesInNamespace(@namespace);
            SafeSelect(comboBox, 0);
        }

        public static void SafeSelect(this ComboBox comboBox, int selectedIndex)
        {
            if (comboBox.Items.Count > selectedIndex)
            {
                comboBox.SelectedIndex = selectedIndex;
            }
        }
    }
}
