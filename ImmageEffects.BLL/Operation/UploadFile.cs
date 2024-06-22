using ImmageEffects.Core.Model;
using ImmageEffects.Core.Operations;
using Microsoft.AspNetCore.Http;

namespace ImmageEffects.BLL.Operation
{
    public class UploadFile : IAddFileOperation
    {
        //File ID Can be Generate in DataBase Side;
        public static int FileID;
        public ImageModel AddFile(IFormFile file, string folderName)
        {
            ImageModel image = new ImageModel();
            if (file != null)
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                using FileStream stream = new FileStream(path + file.FileName, FileMode.Create);
                file.CopyTo(stream);
                image.FileName = file.FileName;
                image.FileFormat = file.ContentType;                
            }
            return image;
        }
        public int GetFileID()
        {
            return ++FileID;
        }
    }
}
