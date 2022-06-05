using H.DataMdel.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataMdel.idenModel
{
    public class UserLogin : IdentityUserLogin<int>
    {
        public virtual UserModel User { get; set; }
    }
}
