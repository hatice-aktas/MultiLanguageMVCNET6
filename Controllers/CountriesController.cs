using Microsoft.AspNetCore.Mvc;

namespace MultiLanguageMVCNET6.Controllers
{
    public class CountriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
