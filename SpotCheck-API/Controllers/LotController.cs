using Microsoft.AspNetCore.Mvc;

namespace SpotCheck_API.Controllers
{
   public class LotController : Controller
   {
      public IActionResult Index()
      {
         return View();
      }
   }
}
