using Microsoft.AspNetCore.Mvc;

namespace ProdajaSlika.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PosaljiPoruku(string ime, string prezime, string email, string poruka)
        {
            ViewBag.Poruka = "Vaša poruka je uspešno poslata!";
            return View("Index");
        }
    }
}
