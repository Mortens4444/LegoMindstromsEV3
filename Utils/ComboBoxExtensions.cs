using System;
using System.Collections;
using System.Linq;
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
            FillAndSelect(comboBox, list, list.Count - 1);
        }

        public static void FillWithTypesInNamespace(this ComboBox comboBox, Assembly assembly, string @namespace)
        {
            var types = assembly.GetTypesInNamespace(@namespace);
            comboBox.DataSource = types.Select(type => new ComboBoxItem(Activator.CreateInstance(type))).ToList();
            SafeSelect(comboBox, 0);
        }

        public static void SafeSelect(this ComboBox comboBox, int selectedIndex)
        {
            if (comboBox.Items.Count > selectedIndex)
            {
                comboBox.SelectedIndex = selectedIndex;
            }
        }

        public static object GetSelectedItemThreadSafe(this ComboBox comboBox)
        {
            try
            {
                return comboBox.Invoke((Func<object>)delegate
                {
                    return comboBox.SelectedItem;
                });
            }
            catch
            {
                return null;
            }
        }
    }
}
