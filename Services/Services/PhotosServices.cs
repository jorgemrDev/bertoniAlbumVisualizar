using Models;
using Repository;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class PhotosServices : IPhotosServices
    {
        IPhotoRepository _photoRepository;
        public PhotosServices(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }
      
        public List<Photo> GetPhotosByAlbumId(int id) {
          return _photoRepository.GetPhotosByAlbumId(id);            
        }
    }
}
