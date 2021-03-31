
using Core.Utilities.Result;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Core.Utilities.FileHelper
{
    public class FileHelper
    {
        public static string Add(IFormFile file)
        {
           
            var sourcePath = Path.GetTempFileName();
            if (file != null)
            {
                using (var stream = new FileStream(sourcePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            string filePath = FilePath(file);
            File.Move(sourcePath, filePath);
           
            return filePath;
        }

        public static IResult Delete(string path)
        {
            File.Delete(path);
            return new SuccessResult();
        }


        public static string Update(string sourcePath, IFormFile file)
        {
            string result = FilePath(file);
            if (sourcePath.Length != 0)
            {
                using (var Upload = new FileStream(result, FileMode.Create)) { file.CopyTo(Upload); }
            }
            File.Delete(sourcePath);
            return result;
        }
        public static string FilePath(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string fileExtension = fileInfo.Extension;

            string path = Environment.CurrentDirectory + @"\Images";
            string newPath = Guid.NewGuid().ToString() + fileExtension;

            string result = $@"{path}\{newPath}";
            return result;
        }



    }
}