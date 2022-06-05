﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataMdel.idenModel
{
    public class Role : IdentityRole<int>
    {
        public virtual ICollection<RoleClaim> RoleClaims { get; set; }
    }
}
