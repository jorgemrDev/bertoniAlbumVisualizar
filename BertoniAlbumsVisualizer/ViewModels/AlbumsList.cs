using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BertoniAlbumsVisualizer.ViewModels
{
    public class AlbumsList
    {
        public IEnumerable<SelectListItem> Albums { set; get; }
        public int SelectedCategory { set; get; }
    }
}
