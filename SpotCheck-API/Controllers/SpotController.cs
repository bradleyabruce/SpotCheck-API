using Microsoft.AspNetCore.Mvc;

namespace SpotCheck_API.Controllers
{
   public class SpotController : Controller
   {
      public IActionResult Index()
      {
         return View();
      }
   }
}
