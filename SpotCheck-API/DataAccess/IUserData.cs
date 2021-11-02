using SpotCheck_API.Contracts.Users;
using SpotCheck_API.Contracts.Users.Requests;
using System.Threading.Tasks;

namespace SpotCheck_API.DataAccess
{
   public interface IUserData
   {
      public Task<int?> Login(LoginRequest request);

      //public Task<User> SignUp(SignupRequest request);
   }
}
