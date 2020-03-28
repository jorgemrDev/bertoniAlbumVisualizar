using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface ICommentsServices
    {
        List<Comments> GetCommentsByPhotoId(int id);
    }
}
