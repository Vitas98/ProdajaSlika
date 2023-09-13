using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProdajaSlika.Models;

namespace ProdajaSlika.Controllers
{
    [Authorize(Roles="Admin")]
    public class AdminController : Controller
    {
        private readonly IPictureRepository _pictureRepository;

        public AdminController(IPictureRepository pictureRepository)
        {
            this._pictureRepository = pictureRepository;
        }
        public IActionResult Index()
        {
            var pictures = _pictureRepository.AllPictures;
            return View(pictures);
        }

        public IActionResult Delete(int id)
        {
            Picture picture = _pictureRepository.GetPictureById(id);
            if (picture == null)
            {
                return NotFound();
            }

            return View(picture.Id);
        }


        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _pictureRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            Picture picture = _pictureRepository.GetPictureWithRelatedEntities(id);
            if (picture == null)
            {
                return NotFound();
            }

            return View(picture);
        }

        [HttpPost]
        public IActionResult Update(Picture izmenjenaSlika)
        {
            if (ModelState.IsValid)
            {
                _pictureRepository.Update(izmenjenaSlika);
                return RedirectToAction("Index");
            }

            return View(izmenjenaSlika);
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Picture novaSlika)
        {
            if (ModelState.IsValid)
            {
                _pictureRepository.Insert(novaSlika);
                return RedirectToAction("Index");
            }

            return View(novaSlika);
        }
    }
}
