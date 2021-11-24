using System;
using System.Windows.Forms;

namespace Utils
{
    public static class ListViewItemExtensions
    {
        public static string ChangeWorkingDirectory(this ListViewItem selectedListViewItem, string currentDirectory)
        {
            if (selectedListViewItem.SubItems[1].Text == ListViewExtensions.Directory)
            {
                if (selectedListViewItem.Text == ListViewExtensions.ParentDirectory)
                {
                    var parentDirectory = currentDirectory.Substring(0, currentDirectory.LastIndexOf('/') + 1).TrimEnd('/');
                    if (parentDirectory == String.Empty)
                    {
                        parentDirectory = "/";
                    }
                    return parentDirectory;
                }
                else
                {
                    var folderSeparator = currentDirectory.EndsWith("/") ? String.Empty : "/";
                    return String.Concat(currentDirectory, folderSeparator, selectedListViewItem.Text);
                }
            }
            return currentDirectory;
        }
    }
}
