using SpotCheck_API.Contracts.Users.Requests;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SpotCheck_API.Helpers.Constants;

namespace SpotCheck_API.DataAccess
{
   public class UserData
   {
      public async Task<int?> Login(LoginRequest request)
      {
         try
         {
            var connStr = @"server=" + DatabaseConnection.ServerAddress + ";userid=" + DatabaseConnection.UserID + ";password=" + DatabaseConnection.Password + ";database=" + DatabaseConnection.Database;
            using (var conn = new MySqlConnection(connStr))
            {
               conn.Open();
               var stm = "SELECT VERSION()";
               var cmd = new MySqlCommand(stm, conn);

               var version = await cmd.ExecuteScalarAsync();
               var test = version.ToString();
            }
         }
         catch
         {
            return 500;
         }

         return 200;
      }
   }
}
