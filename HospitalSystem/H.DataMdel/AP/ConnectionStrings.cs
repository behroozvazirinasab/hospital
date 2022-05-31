using H.Common.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataMdel.AP
{
    public class BMDBContext : BaseContext
    {
        public BMDBContext(string connection) : base(connection)
        {
        }
    }
}
