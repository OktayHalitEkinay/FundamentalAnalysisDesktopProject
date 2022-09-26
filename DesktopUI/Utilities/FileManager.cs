using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI.Business
{
    public static class FileManager
    {
        public static string[] GetPathsOfFiles()
        {
            string[] pathsOfFiles = new string[] { };
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    pathsOfFiles = Directory.GetFiles(fbd.SelectedPath);
                }
            }
            return pathsOfFiles;
        }
    }
}
