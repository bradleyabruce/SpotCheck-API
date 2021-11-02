using Microsoft.AspNetCore.Mvc;

namespace SpotCheck_API.Controllers
{
   public class CameraController : Controller
   {
      public IActionResult Index()
      {
         return View();
      }
   }
}
