using Models;
using Repository;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class CommentsServices : ICommentsServices
    {
        ICommentsRepository _commentsRepository;
        public CommentsServices(ICommentsRepository commentsRepository)
        {
            _commentsRepository = commentsRepository;
        }

        public List<Comments> GetCommentsByPhotoId(int id)
        {
            return _commentsRepository.GetCommentsByPhotoId(id);
        }
    }
}
