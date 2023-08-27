using Microsoft.AspNetCore.Mvc;

namespace ProdajaSlika.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
