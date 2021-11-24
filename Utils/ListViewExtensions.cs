using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Utils
{
    public static class ListViewExtensions
    {
        public const string Directory = "DIR";

        public const string ParentDirectory = "..";

        public static void PopulateWithLegoMindstormEV3FolderContent(this ListView listView, IEnumerable<string> folderContent, bool addLinkToParentDirectory)
        {
            listView.Items.Clear();

            ListViewItem listViewItem;
            if (addLinkToParentDirectory)
            {
                listViewItem = new ListViewItem
                {
                    Text = ParentDirectory
                };
                listViewItem.SubItems.Add(Directory);
                listView.Items.Add(listViewItem);
            }

            foreach (var item in folderContent)
            {
                listViewItem = new ListViewItem();
                if (item != "../")
                {
                    if (item.EndsWith("/"))
                    {
                        listViewItem.Text = item.TrimEnd('/');
                        listViewItem.SubItems.Add(Directory);
                    }
                    else
                    {
                        var properties = item.Split(' ');
                        if (properties.Length > 2)
                        {
                            var fileSize = Int32.Parse(properties[1], NumberStyles.HexNumber);
                            listViewItem.Text = properties[2];
                            listViewItem.SubItems.Add(String.Empty);
                            listViewItem.SubItems.Add(fileSize.ToString());
                        }
                    }
                    listView.Items.Add(listViewItem);
                }
            }
        }
    }
}
