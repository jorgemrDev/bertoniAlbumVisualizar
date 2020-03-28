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
    public class CommentsRepository : ICommentsRepository
    {
        string url = "https://jsonplaceholder.typicode.com/comments/";
        List<Comments> _commentsList;

        public List<Comments> GetCommentsByPhotoId(int id)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);
            _commentsList = JsonConvert.DeserializeObject<List<Comments>>(reply);
            return _commentsList.Where(e=> e.postId == id).ToList();
        }
    }
}
