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
            new Article { Id = 1, Image = "https://www.nps.gov/yose/planyourvisit/images/IMG_1192edit.jpg?maxwidth=650&autorotate=false&quality=78&format=webp", Title = "Lower Yosemite Fall Trail", Summary = "An easy trail with a length of 1 mi / 1.6 km (entire loop)." },
            new Article { Id = 2, Image = "https://www.nps.gov/yose/planyourvisit/images/Half-Dome-Cables-735.jpg?maxwidth=650&autorotate=false&quality=78&format=webp", Title = "Half Dome Trail", Summary = "A strenuous trail with a length of 14 mi-16.4 mi / 22.4 km-26.2 km (round trip)." }
        };

            return View(articles);
        }

        public IActionResult Details(int id)
        {
            var article = new Article { Id = id, Title = $"Article {id} of Trail", Summary = "Please refer to preparation rules stated from the official website at nps.gov, and happy hiking!" };
            return View(article);
        }
    }
}
