using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChuongForums.Data;
using ChuongForums.Data.Models;
using ChuongForums.Models.Forum;
using Microsoft.AspNetCore.Mvc;

namespace ChuongForums.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        public ForumController(IForum forumService)
        {
            _forumService = forumService;
        }
        public IActionResult Index()
        {
            IEnumerable<ForumListingModel> forums = _forumService.GetAll()
                .Select(forum => new ForumListingModel()
                {
                    Id = forum.Id,
                    Name = forum.Title,
                    Description = forum.Description
                });
            var model = new ForumIndexModel()
            {
                ForumList = forums
            };

            return View(model);
        }

        public IActionResult Topic(int id)
        {
            var forums = _forumService.GetById(id);
        }
    }
}