using System.IO;
using System.Threading.Tasks;
using System.Web;

namespace Apartments.Utils
{
    public static class IOUtils
    {
        public static async Task CreateDirectoryIfNotExistAsync(string path)
        {
            await Task.Run(() => Directory.CreateDirectory(path));
        }

        public static async Task SavePostedFilesAsync(HttpPostedFileBase[] files, string pathToSave)
        {
            foreach (HttpPostedFileBase file in files)
            {
                if (file != null)
                {
                    var InputFileName = Path.GetFileName(file.FileName);
                    await Task.Run(() => file.SaveAs(pathToSave));
                }
            }
        }
    }
}