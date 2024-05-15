using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class _LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
