using System.IO;
using System.Threading.Tasks;

namespace Apartments.Utils
{
    public static class IOUtils
    {
        public static async Task CreateDirectoryIfNotExist(string path)
        {
            await Task.Run(() => Directory.CreateDirectory(path));
        }
    }
}