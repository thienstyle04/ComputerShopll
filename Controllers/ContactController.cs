using ComputerShopll.Data;
using ComputerShopll.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComputerShopll.Controllers
{
    public class ContactController : Controller
    {
        private readonly ComputershopDbContext context;
        public ContactController(ComputershopDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactMessage message)
        {
            if (ModelState.IsValid)
            {
                context.ContactMessages.Add(message);
                context.SaveChanges();
                TempData["Success"] = "Cảm ơn bạn đã gửi phản hồi!";
                return RedirectToAction("ThankYou");
            }
            return View("Index", message);
        }
        public IActionResult ThankYou()
        {
            return View();
        }

    }
}
