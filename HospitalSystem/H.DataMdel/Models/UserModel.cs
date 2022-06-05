using H.DataMdel.idenModel;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H.DataMdel.Models
{
    public class UserModel : IdentityUser<int>
    {
        public DateTime CreatedDateTime { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public virtual ICollection<UserClaim> UserClaims { get; set; }

        public virtual ICollection<UserLogin> UserLogins { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        public virtual ICollection<UserToken> UserTokens { get; set; }
    }
}
