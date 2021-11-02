using Microsoft.AspNetCore.Mvc;
using SpotCheck_API.Contracts.Users.Requests;
using SpotCheck_API.Contracts.Users.Responses;
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
         return new LoginResponse();
      }
   }
}
