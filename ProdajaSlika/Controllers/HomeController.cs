using Microsoft.AspNetCore.Mvc;
using ProdajaSlika.Models;
using ProdajaSlika.ViewModels;
using System.Diagnostics;

namespace ProdajaSlika.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPictureRepository _pictureRepository;

        public HomeController(ILogger<HomeController> logger, IPictureRepository pictureRepository)
        {
            _logger = logger;
            this._pictureRepository = pictureRepository;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.SpecialOffers = _pictureRepository.SpecialOfferPictures;

            return View(model);
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