using System.IO;
using System.Web.Mvc;
using Apartments.Data;
using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

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

        public string SaveImagesAndReturnGUID()
        {
            return Guid.NewGuid().ToString();
        }
        
        [HttpPost]
        public async Task<ActionResult> MultipleFilesUploadWithGUID(HttpPostedFileBase[] files)
        {
            string pathes = string.Empty;
            string guid = Guid.NewGuid().ToString();
            await Utils.IOUtils.CreateDirectoryIfNotExistAsync(Path.Combine(pathToImages, guid));
            if (ModelState.IsValid)
            {   
                foreach (HttpPostedFileBase file in files)
                {
                    if (file != null)
                    {
                        var InputFileName = Path.GetFileName(file.FileName);
                        string pathToSave = Path.Combine(pathToImages, guid, InputFileName);
                        await Task.Run(() => file.SaveAs(pathToSave));  
                        ViewBag.UploadStatus = files.Length.ToString() + " files uploaded successfully.";
                        ViewBag.ImagesPathesToApartment = ViewBag.ImagesPathesToApartment + ";" + pathToSave;
                    }
                }
            }
            ViewBag.GUID = guid;
            return await Task.Run(() => RedirectToActionPermanent("Test", "Aps"));
        }

        public class FileModel
        {
            [Required(ErrorMessage = "Please select file.")]
            [Display(Name = "Browse File")]
            public HttpPostedFileBase[] files { get; set; }
        }

        public class DomainAppWithImages
        {
            public FileModel fileModel { get; set; }
            public Models.Postgres.Apartment apartment { get; set; }
        }
    }
}