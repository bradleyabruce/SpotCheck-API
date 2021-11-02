using SpotCheck_API.Helpers.Constants;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SpotCheck_API.Contracts.Users.Requests
{
   public class LoginRequest
   {
      [DataMember]
      [DisplayName("Username")]
      [Required(ErrorMessage = DataContractConstants.RequiredErrorMessage)]
      [StringLength(100, ErrorMessage = DataContractConstants.StringLengthErrorMessage)]
      public string Username { get; set; }

      [DataMember]
      [DisplayName("Password")]
      [Required(ErrorMessage = DataContractConstants.RequiredErrorMessage)]
      [StringLength(100, ErrorMessage = DataContractConstants.StringLengthErrorMessage)]
      public string Password { get; set; }
   }
}
