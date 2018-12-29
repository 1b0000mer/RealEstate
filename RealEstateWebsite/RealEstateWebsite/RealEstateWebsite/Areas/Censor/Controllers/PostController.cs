using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RealEstateWebsite.Models;

namespace RealEstateWebsite.Areas.Censor.Controllers
{

    public class PostController : Controller
    {
        RealEstateWebsiteEntities db = new RealEstateWebsiteEntities();
        // GET: Censor/Post
        public ViewResult Censorship()
        {
            List<Post> lstPost = db.Posts.Where(n => n.Status == 1).Take(10).ToList();
            return View(lstPost);
        }
    }
}