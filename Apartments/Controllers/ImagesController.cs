using System.IO;
using System.Web.Mvc;
using Apartments.Data;

namespace Apartments.Controllers
{
    public class ImagesController : Controller
    {
        private static string pathToImages = @"D:\ApartmentsImages";

        [Route("Images/{apId}/{image}")]
        public FileResult GetImage(string apId, string image)
        {
            string finalImageName = image.Contains(".") ? image : image + ControllersConstants.pngFormat;
            string path = Path.Combine(pathToImages, apId, finalImageName);
            return new FileStreamResult(new FileStream(path, FileMode.Open), ControllersConstants.imageJpegContType);
        }

        [Route("Images/{apId}/{image}/{type}")]
        public FileResult GetImage(string apId, string image, string type = ControllersConstants.pngFormat)
        {
            string finalImageName = image.Contains(".") ? image : image + type;
            string path = Path.Combine(pathToImages, apId, finalImageName);
            return new FileStreamResult(new FileStream(path, FileMode.Open), ControllersConstants.imageJpegContType);
        }
    }
}