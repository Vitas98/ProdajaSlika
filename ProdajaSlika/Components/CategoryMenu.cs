using Microsoft.AspNetCore.Mvc;
using ProdajaSlika.Models;

namespace ProdajaSlika.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.AllCategories.OrderBy(c => c.Name);
            return View(categories);
        }
    }
}
