using SpotCheck_API.Helpers.Constants;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SpotCheck_API.Contracts.Users
{
   [DataContract]
   public class User
   {
      [DataMember]
      public int UserID { get; set; }

      [DataMember]
      [DisplayName("First Name")]
      [StringLength(100, ErrorMessage = DataContractConstants.StringLengthErrorMessage)]
      public string FirstName { get; set; }

      [DataMember]
      [DisplayName("Last Name")]
      [StringLength(100, ErrorMessage = DataContractConstants.StringLengthErrorMessage)]
      public string LastName { get; set; }

      [DataMember]
      [DisplayName("Email")]
      [StringLength(100, ErrorMessage = DataContractConstants.StringLengthErrorMessage)]
      [EmailAddress]
      public string Email { get; set; }

      [DataMember]
      [DisplayName("Username")]
      [StringLength(100, ErrorMessage = DataContractConstants.StringLengthErrorMessage)]
      public string Username { get; set; }

      [DataMember]
      [DisplayName("Password")]
      [StringLength(100, ErrorMessage = DataContractConstants.StringLengthErrorMessage)]
      public string Password { get; set; }

      [DataMember]
      [DisplayName("IsDeleted")]
      public bool IsDeleted { get; set; }
   }
}
