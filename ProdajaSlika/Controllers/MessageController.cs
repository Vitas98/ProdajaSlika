using Microsoft.AspNetCore.Mvc;
using ProdajaSlika.Models;

namespace ProdajaSlika.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageRepository _messageRepository;

        public MessageController(IMessageRepository messageRepository)
        {
            this._messageRepository = messageRepository;
        }


        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Message novaPoruka)
        {
            if (ModelState.IsValid)
            {
                _messageRepository.Insert(novaPoruka);
                return RedirectToAction("InsertConfirm");
            }
            return View("Insert");
        }
        public IActionResult InsertConfirm() 
        {
            return View();
        }
    }
}
