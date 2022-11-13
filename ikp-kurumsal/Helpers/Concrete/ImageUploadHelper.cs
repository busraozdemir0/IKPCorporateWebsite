using ikp_kurumsal.Helpers.Abstract;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ikp_kurumsal.Helpers.Concrete
{
    public class ImageUploadHelper : IImageUploadHelper
    {
        IWebHostEnvironment _webHost;
        public ImageUploadHelper(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
        }

        public async Task<string> Upload(IFormFile file, string path)
        {
            string wwwRootPath = _webHost.WebRootPath;
            string filename = Path.GetFileNameWithoutExtension(file.FileName);
            string extension = Path.GetExtension(file.FileName);
            filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            string fullPath = Path.Combine(wwwRootPath + path);

            if (System.IO.Directory.Exists(fullPath) == false)
            {
                System.IO.Directory.CreateDirectory(fullPath);
            }

            string fullPathWithImage = Path.Combine(wwwRootPath + path, filename);

            using (var filestream = new FileStream(fullPathWithImage, FileMode.Create))
            {
                await file.CopyToAsync(filestream);
            }

            return filename;
        }

        public void Delete(string path, string imageName)
        {
            if (imageName != null)
            {
                string wwwRootPath = _webHost.WebRootPath;
                string fullPath = Path.Combine(wwwRootPath + path, imageName);

                if (System.IO.File.Exists(fullPath))
                {
                    System.IO.File.Delete(fullPath);
                }
            }
        }
    }
}
