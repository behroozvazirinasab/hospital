using H.DataMdel.Models;
using Microsoft.AspNetCore.Identity;

namespace H.DataMdel.idenModel;

public class UserToken : IdentityUserToken<int>
{
    public virtual UserModel User { get; set; }
}
