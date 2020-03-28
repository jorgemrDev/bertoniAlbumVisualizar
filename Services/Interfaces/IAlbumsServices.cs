using Models;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IAlbumsServices
    {
        List<Album> GetAlbumsAll();
        Album GetAlbumsById(int id);
    }
}
