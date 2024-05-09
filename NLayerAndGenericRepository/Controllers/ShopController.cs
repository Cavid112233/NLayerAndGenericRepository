using Microsoft.AspNetCore.Mvc;

namespace NLayerAndGenericRepository.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SingleProductVariable()
        {
            return View();
        }
    }
}
