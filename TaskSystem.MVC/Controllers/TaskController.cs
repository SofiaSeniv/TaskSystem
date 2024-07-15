using Microsoft.AspNetCore.Mvc;

namespace TaskSystem.MVC.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
