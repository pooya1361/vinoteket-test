using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VinoteketTestWebApp.Services;

namespace VinoteketTestWebApp.Controllers
{
    public class HomeController : Controller
    {
        private ArticleService _articleService;

        public HomeController(ArticleService articleService)
        {
            this._articleService = articleService;
        }

        public ActionResult Index()
        {
            var articles = _articleService.GetAllArticles();
            ViewBag.Articles = articles;

            return View();
        }

        public ActionResult Details(string url)
        {
            var article = _articleService.GetArticle(url);
            ViewBag.article = article;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Vinoteket test application";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Do you need help?";

            return View();
        }
    }
}