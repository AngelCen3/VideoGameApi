using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using System.Xml.Linq;

namespace VideoGameApi.Controllers
{
    [Route("apigj/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        static private List<VideoGame> videoGames = new List<VideoGame>
        {
            new VideoGame
            {
                Id = 1,
                Title = "Spider-Man 2",
                Platform = "PS5",
                Developer = "Insomniac Games",
                Publishser = "Sony Interactive Entertainment"
            },
            new VideoGame
            {
                Id = 2,
                Title = "Call Of Duty",
                Platform = "PS3",
                Developer = "Mafia Games",
                Publishser = "Interactive "
            },
            new VideoGame
            {
                Id = 3,
                Title = "Mario Car",
                Platform = "Nintendo",
                Developer = "Craft Games",
                Publishser = "Belong"
            }
};
            [HttpGet]
            public ActionResult<List<VideoGame>> GetVideoGames()
            {
                Console.WriteLine("Touth Test");
                return Ok(videoGames);
                
            }
            
        }

    }
