using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ElArabia.Helper
{
    public class UploadImagesHelper
    {
        public static string UploadImage(IFormFile FormFile, string type)
        {
            var file = FormFile;

            var folderName = Path.Combine("wwwroot");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            if (!Directory.Exists(pathToSave))
            {
                Directory.CreateDirectory(pathToSave);
            }
            pathToSave = Path.Combine(pathToSave, type);
            if (!Directory.Exists(pathToSave))
            {
                Directory.CreateDirectory(pathToSave);
            }
            if (file.Length > 0)
            {
                var fileName = DateTime.Now.Ticks + ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                var fullPath = Path.Combine(pathToSave, fileName);
                var dbPath = Path.Combine(folderName, fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                return "~/" + type + "/" + fileName;
            }
            return "";
        }

    }
}
