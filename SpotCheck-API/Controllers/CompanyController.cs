using Microsoft.AspNetCore.Mvc;

namespace SpotCheck_API.Controllers
{
   public class CompanyController : Controller
   {
      public IActionResult Index()
      {
         return View();
      }
   }
}
