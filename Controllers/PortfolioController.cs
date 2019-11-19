using Microsoft.AspNetCore.Mvc;

namespace aywevents.Controllers
{
    public class PortfolioController : Controller
    {

        public IActionResult Index(){
            return View();
        }
        public IActionResult Details(){
            return View();
        }
        
    }
}