using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NationalityGuess.Domain.Model.Nationalitie;
using System.Linq;

namespace NationalityGuess.Controllers
{
    [Route("players")]
    public class PlayerController : Controller
    {
        private readonly ILogger<PlayerController> logger;

        public PlayerController(ILogger<PlayerController> logger)
        {
            this.logger = logger;
        }


        // GET: Players
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: Players/Details/5
      
    }
}
