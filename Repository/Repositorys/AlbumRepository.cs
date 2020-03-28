using Models;
using Newtonsoft.Json;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Repository.Repositorys
{
    public class AlbumRepository : IAlbumsRepository
    {
        string url = "https://jsonplaceholder.typicode.com/albums";
        List<Album> _albumsList;

        public AlbumRepository()
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);
            _albumsList = JsonConvert.DeserializeObject<List<Album>>(reply);
        }
        public List<Album> GetAlbumsAll()
        {
            return _albumsList;
        }
        public Album GetAlbumById(int id)
        {
            return _albumsList.Where(e => e.id == id).FirstOrDefault();
        }

    }
}
