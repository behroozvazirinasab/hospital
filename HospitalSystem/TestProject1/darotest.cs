using HospitalSystem.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Xunit;

namespace TestProject1
{
    public class darotest
    {
        [Fact]
        public void list_return()
        {
            //act
            var result = DaroController.List() as ViewResult;
        }
    }
}
