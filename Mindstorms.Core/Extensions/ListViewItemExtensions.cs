using System.Windows.Forms;

namespace Mindstorms.Core.Extensions;

public static class ListViewItemExtensions
{
    public static bool IsDirectory(this ListViewItem listViewItem)
    {
        return listViewItem.SubItems[1].Text == ListViewExtensions.Directory;
    }

    public static int GetFileSize(this ListViewItem listViewItem)
    {
        return Convert.ToInt32(listViewItem.SubItems[2].Text);
    }

    public static string ChangeWorkingDirectory(this ListViewItem selectedListViewItem, string currentDirectory)
    {
        if (selectedListViewItem.IsDirectory())
        {
            if (selectedListViewItem.Text == ListViewExtensions.ParentDirectory)
            {
                var parentDirectory = currentDirectory[..(currentDirectory.LastIndexOf('/') + 1)].TrimEnd('/');
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
