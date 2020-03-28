using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IPhotoRepository
    {
        List<Photo> GetPhotosByAlbumId(int id); 
    }
}
