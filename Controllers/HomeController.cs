using ComputerShopll.Models.Interfaces;
using ComputerShopll.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComputerShopll.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository productRepository;
        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var randomProducts = productRepository.GetAllProducts()
                                    .OrderBy(x => Guid.NewGuid()) // Sắp xếp ngẫu nhiên
                                    .Take(3)                       // Lấy 3 sản phẩm
                                    .ToList();

            return View(randomProducts);
        }
    }
}
