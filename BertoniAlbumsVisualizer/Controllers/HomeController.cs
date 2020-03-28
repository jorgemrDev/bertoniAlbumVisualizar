using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BertoniAlbumsVisualizer.Models;
using Services;
using Services.Interfaces;
using Models;
using BertoniAlbumsVisualizer.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BertoniAlbumsVisualizer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAlbumsServices _albumsServices;
        private readonly IPhotosServices _photosServices;
        private readonly ICommentsServices _commentsServices;

        public HomeController(ILogger<HomeController> logger, IAlbumsServices albumsServices, IPhotosServices photosServices, ICommentsServices commentsServices)
        {
            _logger = logger;
            _albumsServices = albumsServices;
            _photosServices = photosServices;
            _commentsServices = commentsServices;
        }

        public IActionResult Index()
        {
            List<SelectListItem> albumListItems = new List<SelectListItem>();
            List<Album> albumsList = _albumsServices.GetAlbumsAll();
            foreach (var item in albumsList)
            {
                SelectListItem selectItem = new SelectListItem()
                {
                    Text = item.title,
                    Value = item.id.ToString()
                };
                albumListItems.Add(selectItem);
            }

            var vm = new AlbumsList();
            vm.Albums = albumListItems;
            return View(vm);         
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult VisualizeAlbum(AlbumsList model)
        {            
            return View(_photosServices.GetPhotosByAlbumId(model.SelectedCategory));
        }

        public ActionResult ViewComments(int id) {
            return  PartialView("~/Views/Home/_Comments.cshtml", _commentsServices.GetCommentsByPhotoId(id));
        }

    }
}
