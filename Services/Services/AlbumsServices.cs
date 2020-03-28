

using Models;
using Repository;
using Repository.Interfaces;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services.Services
{
    public class AlbumsServices : IAlbumsServices
    {
        IAlbumsRepository _albumsRepository;
        public AlbumsServices(IAlbumsRepository albumsRepository)
        {
            _albumsRepository = albumsRepository;
        }
        public List<Album> GetAlbumsAll()
        {
            List<Album> lstAlbums = _albumsRepository.GetAlbumsAll();
            return lstAlbums;
        }
        public Album GetAlbumsById(int id)
        {
            return _albumsRepository.GetAlbumById(id);
        }
    }
}
