using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Utils
{
    public static class AssemblyExtensions
    {
        public static IList<ComboBoxItem> GetTypesInNamespace(this Assembly assembly, string @namespace)
        {
            return assembly.GetTypes()
                .Where(type => type.Namespace == @namespace)
                .OrderBy(type => type.Name)
                .Select(type => new ComboBoxItem(Activator.CreateInstance(type)))
                .ToList();
        }
    }
}
