using Microsoft.AspNetCore.Mvc;

namespace ExampleMVCProject.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return RedirectToAction("Index","Ornek");
        }

        public IActionResult ContentResult()
        {
            return Content("ContentResult");
        }

        public IActionResult JsonResult()
        {
            return Json(new { Id = 1, name = "Enes", price = 100 });
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
    }
}
