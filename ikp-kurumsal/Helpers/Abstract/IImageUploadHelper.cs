using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ikp_kurumsal.Helpers.Abstract
{
    public interface IImageUploadHelper
    {
        Task<string> Upload(IFormFile file, string path);
        void Delete(string path, string imageName);
    }
}
