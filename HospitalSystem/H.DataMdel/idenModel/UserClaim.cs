using H.DataMdel.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataMdel.idenModel
{
    public class UserClaim : IdentityUserClaim<int>
    {
        public virtual UserModel User { get; set; }
    }
}
