using FrontBackTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontBackTask.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }




}
