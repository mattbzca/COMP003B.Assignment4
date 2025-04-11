using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Models;

namespace COMP003B.Assignment4.Controllers
{
    public class VideoController : Controller
    {
        public IActionResult Videos()
        {
            var videos = new List<Video>
            {
                new Video { Id = 1, Title = "Easy Yosemite Valley Day Hikes", Url = "https://www.nps.gov/media/video/embed.htm?id=FBE15921-C7CF-136F-0C7595617D490CD0", Summary = "In this video, a ranger describes easy hikes in Yosemite Valley to Bridalveil Fall, Mirror Lake, and Lower Yosemite Fall." },
                new Video { Id = 2, Title = "Moderate Yosemite Valley Day Hikes", Url = "https://www.nps.gov/media/video/embed.htm?id=F882C994-C0AF-8942-D9DB9D593A99893F", Summary = "In this video, a ranger describes moderate hikes in Yosemite Valley, including, the Valley Loop Trail, the trail to the Vernal Fall Footbridge, and Columbia Rock." },
                new Video { Id = 3, Title = "Strenuous Yosemite Valley Day Hikes", Url = "https://www.nps.gov/media/video/embed.htm?id=00514DD3-D013-5D9A-EB6F29EBDDDD4B76", Summary = "In this video, a ranger describes strenuous hikes in Yosemite Valley, including the Yosemite Falls Trail, Mist Trail to the top of Nevada Fall, and Panorama Trail." }
            };

            return View(videos);
        }
    }
}
