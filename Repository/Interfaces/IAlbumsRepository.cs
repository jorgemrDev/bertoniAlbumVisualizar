using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IAlbumsRepository
    {
        List<Album> GetAlbumsAll();
        Album GetAlbumById(int id);
    }
}
