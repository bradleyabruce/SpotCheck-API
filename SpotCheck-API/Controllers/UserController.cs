using Microsoft.AspNetCore.Mvc;
using SpotCheck_API.Contracts.Users.Requests;
using SpotCheck_API.Contracts.Users.Responses;
using SpotCheck_API.DataAccess;
using System.Threading.Tasks;

namespace SpotCheck_API.Controllers
{
   [Route("users")]
   public class UserController : Controller
   {
      [HttpPost]
      [Route("login")]
      public async Task<LoginResponse> Login([FromBody] LoginRequest request)
      {
         var test = new UserData();
         await test.Login(request);
         return new LoginResponse();
      }
   }
}
