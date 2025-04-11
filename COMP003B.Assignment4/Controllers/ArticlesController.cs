using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Models;

namespace COMP003B.Assignment4.Controllers
{
    public class ArticlesController : Controller
    {
        public IActionResult Index()
        {
            var articles = new List<Article>
        {
            new Article { Id = 1, Title = "Intro to Razor", Summary = "Learn the basics of Razor syntax." },
            new Article { Id = 2, Title = "Layouts and Partials", Summary = "Understand Razor layouts and reusable views." }
        };

            return View(articles);
        }

        public IActionResult Details(int id)
        {
            var article = new Article { Id = id, Title = $"Article {id}", Summary = "Detailed content coming soon." };
            return View(article);
        }
    }
}
