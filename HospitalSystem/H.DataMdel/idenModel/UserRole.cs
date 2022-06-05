using H.DataMdel.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataMdel.idenModel
{
    public class UserRole : IdentityUserRole<int>
    {
        public virtual UserModel User { get; set; }
        public virtual Role Role { get; set; }
    }
}
