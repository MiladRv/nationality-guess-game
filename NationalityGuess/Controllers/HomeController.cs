using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NationalityGuess.Domain.Model.Nationalitie;
using NationalityGuess.Models;
using System.Diagnostics;
using System.Linq;

namespace NationalityGuess.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INationalityRepository nationalityRepository;
        public HomeController(ILogger<HomeController> logger, INationalityRepository nationalityRepository)
        {
            _logger = logger;
            this.nationalityRepository = nationalityRepository;
        }

        public IActionResult Index()
        {

            return View();
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
    }
}
