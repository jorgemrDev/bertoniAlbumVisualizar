using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface ICommentsRepository
    {
        List<Comments> GetCommentsByPhotoId(int id);
    }
}
