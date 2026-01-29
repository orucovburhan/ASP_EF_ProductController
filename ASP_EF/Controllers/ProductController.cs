using Microsoft.AspNetCore.Mvc;

namespace ASP_EF.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
