using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Maintenance
{
    internal class FileExistance
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        internal static extern int GetLongPathName(string path, StringBuilder longPath, int longPathLength);

        internal static bool FileExists(string filename)
        {
            try
            {
                StringBuilder longPath = new StringBuilder(255);
                GetLongPathName(Path.GetFullPath(filename), longPath, longPath.Capacity);

                if (File.Exists(longPath.ToString()))
                {
                    return true;
                }
                if (Directory.Exists(longPath.ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
