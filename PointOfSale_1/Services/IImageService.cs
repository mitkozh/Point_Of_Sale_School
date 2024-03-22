using PointOfSale_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_1.Services
{
    public interface IImageService
    {
        Image SaveOrUpdateImage(string filePath, string fileName, string contentType);
        void RemoveImage(string fileName);
        System.Drawing.Image GetImage(string fileName);
        System.Drawing.Image GetImage(int idToSearch);
    }
}
