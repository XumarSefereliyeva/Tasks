using CharityProjectMVC.Models;
using CharityProjectMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace CharityProjectMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CauseController : Controller
    {
        private readonly CauseService _causeservice;

        public CauseController()
        {
            _causeservice = new CauseService();
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Cause> causes = _causeservice.GetAllCause();
            return View(causes);
        }
        [HttpGet]
        #region Create
        public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult Create(Cause cause)
        {
            _causeservice.AddCause(cause);
            return RedirectToAction(nameof(Index));
        }
        #endregion
        [HttpGet]
        #region Info
        public IActionResult Info(int id)
        {
            Cause c = _causeservice.GetCauseById(id);
            return View(c);
        }
        #endregion

        #region Update
        [HttpGet]
        public IActionResult Update(int id)
        {
            Cause c= _causeservice.GetCauseById(id);
            return View(c);
        }
        [HttpPost]
        public IActionResult Update(int id, Cause cause)
        {
            _causeservice.GetCauseById(id);
            _causeservice.Update(id, cause);
            return RedirectToAction(nameof(Index));
        }
        #endregion

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _causeservice.Delete(id);
            return RedirectToAction(nameof(Index));
        }
       
    }

}
