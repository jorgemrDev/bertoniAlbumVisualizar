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
    public class PhotosRepository : IPhotoRepository
    {
        string url = "https://jsonplaceholder.typicode.com/photos/";
        List<Photo> _photosList;
                
        public List<Photo> GetPhotosByAlbumId(int id)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);
            _photosList = JsonConvert.DeserializeObject<List<Photo>>(reply);
            return _photosList.Where(e => e.albumId == id).ToList();
        }
    }
}
