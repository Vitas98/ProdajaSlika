using Microsoft.AspNetCore.Mvc;
using ProdajaSlika.Models;
using ProdajaSlika.ViewModels;

namespace ProdajaSlika.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPictureRepository _pictureRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPictureRepository pictureRepository, ShoppingCart shoppingCart)
        {
            this._pictureRepository = pictureRepository;
            this._shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                TotalPrice = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int picId)
        {
            var selectedPic = _pictureRepository.AllPictures.FirstOrDefault(p => p.Id == picId);

            if (selectedPic != null)
            {
                _shoppingCart.AddToCart(selectedPic, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int picId)
        {
            var selectedPic = _pictureRepository.AllPictures.FirstOrDefault(p => p.Id == picId);

            if (selectedPic != null)
            {
                _shoppingCart.RemoveFromCart(selectedPic);
            }
            return RedirectToAction("Index");
        }
    }
}
