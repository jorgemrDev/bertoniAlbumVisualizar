using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IPhotosServices
    {
        List<Photo> GetPhotosByAlbumId(int id);
    }
}
