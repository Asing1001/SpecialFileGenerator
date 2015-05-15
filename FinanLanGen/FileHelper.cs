using System.Windows.Forms;

namespace FinanLanGen
{
    static class FileHelper
    {

        public static string OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            return string.Empty;
        }

        public static string OpenFolder()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog.SelectedPath;
            }
            return string.Empty;
        }
    }
}
