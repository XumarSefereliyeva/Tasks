using Microsoft.AspNetCore.Mvc;

namespace CharityProjectMVC.Areas.Admin.Controllers
{
    public class DashBoardController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
