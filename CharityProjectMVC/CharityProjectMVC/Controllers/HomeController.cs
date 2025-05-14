using CharityProjectMVC.Contexts;
using CharityProjectMVC.Models;
using CharityProjectMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CharityProjectMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly CauseService _causeservice;

        public HomeController()
        {
            _causeservice = new CauseService();
        }
        public IActionResult Index()
        {
         List<Cause> causes=_causeservice.GetAllCause();
            return View(causes);
        }
    }
}
