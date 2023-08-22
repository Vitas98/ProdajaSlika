using Microsoft.AspNetCore.Mvc;
using ProdajaSlika.Models;
using ProdajaSlika.ViewModels;

namespace ProdajaSlika.Controllers
{
    public class PictureController : Controller
    {
        private readonly IPictureRepository _pictureRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PictureController(IPictureRepository pictureRepository, ICategoryRepository categoryRepository)
        {
            this._pictureRepository = pictureRepository;
            this._categoryRepository = categoryRepository;
        }

        public ViewResult List(int? categoryId)
        {
            PictureListViewModel model = new PictureListViewModel()
            {
                Pictures = _pictureRepository.AllPictures,
                CurrentCategory = "Sve slike",
                Category = new Category { Id = 0, Description= "Ukoliko želite Vašu sliku, pošaljite jednu ili više svojih fotografija putem e-mail adrese.", Name="", Pictures = null}
            };

            if (categoryId.HasValue)
            {
                model.Pictures = _pictureRepository.AllPictures.Where(c => c.CategoryId == categoryId);
                model.CurrentCategory = _categoryRepository.AllCategories.Where(c => c.Id == categoryId).Select(c => c.Name).FirstOrDefault();
                model.Category = _categoryRepository.AllCategories.Where(c => c.Id == categoryId).FirstOrDefault();
            }

            return View(model);
        }

        public IActionResult Details(int id)
        {
            Picture pic = _pictureRepository.GetPictureById(id);

            if (pic == null)
            {
                return NotFound();
            }

            return View(pic);
        }
    }
}
