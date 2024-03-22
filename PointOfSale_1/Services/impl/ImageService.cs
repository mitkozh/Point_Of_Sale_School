using Microsoft.EntityFrameworkCore.Query;
using PointOfSale_1.Context;
using PointOfSale_1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_1.Services.impl
{
    public class ImageService : IImageService
    {
        private DbPosContext _dbPosContext;

        public ImageService(DbPosContext dbPosContext)
        {
            _dbPosContext = dbPosContext;
        }
        public Image SaveOrUpdateImage(string filePath, string fileName, string contentType)
        {
            byte[] imageBytes = File.ReadAllBytes(filePath);

            var existingImage = _dbPosContext.Images.FirstOrDefault(img => img.FileName == fileName);
            if (existingImage != null)
            {
                existingImage.ImageBytes = imageBytes;
                existingImage.ContentType = contentType;
                _dbPosContext.SaveChanges();
                return existingImage;
            }
            else
            {
                var newImage = new Models.Image
                {
                    ImageBytes = imageBytes,
                    FileName = fileName,
                    ContentType = contentType
                };
                _dbPosContext.Images.Add(newImage);
                _dbPosContext.SaveChanges();
                return newImage;
            }
        }


        public void RemoveImage(string fileName)
        {
            var existingImage = _dbPosContext.Images.FirstOrDefault(img => img.FileName == fileName);
            if (existingImage != null)
            {
                _dbPosContext.Images.Remove(existingImage);
                _dbPosContext.SaveChanges();
            }
        }

        public System.Drawing.Image GetImage(string fileName)
        {
            var existingImage = _dbPosContext.Images.FirstOrDefault(img => img.FileName == fileName);
            if (existingImage != null)
            {
                using (MemoryStream ms = new MemoryStream(existingImage.ImageBytes))
                {
                    return System.Drawing.Image.FromStream(ms);
                }
            }
            return null;
        }

        public System.Drawing.Image GetImage(int idToSearch)
        {
            var existingImage = _dbPosContext.Images.FirstOrDefault(img => img.Id == idToSearch);
            if (existingImage != null)
            {
                using (MemoryStream ms = new MemoryStream(existingImage.ImageBytes))
                {
                    return System.Drawing.Image.FromStream(ms);
                }
            }
            return null;
        }
    }
}
