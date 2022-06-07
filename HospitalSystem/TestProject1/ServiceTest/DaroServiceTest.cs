using H.DataLayer.Context;
using H.DataMdel.Models;
using H.Services.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class DaroServiceTest
    {
        [Fact]
        public void Should_Save_Daro()
        {
            //Arrange
            var dbOptions = new DbContextOptionsBuilder<HDbContext>()
               .UseInMemoryDatabase("ShouldSaveTest",
                                    b => b.EnableNullChecks(false))
               .Options;

            var daro = new DaroModel { ID = 5, Title = "5555", Description = "desssssss" };

            //Act
            using var context = new HDbContext(dbOptions);
            var DaroServiceTest = new DaroService(context);
            DaroServiceTest.Add(daro);

            //Assert
            var daros = context.Daros.ToList();
            var daroo = Assert.Single(daros);

            Assert.Equal(daro.Title, daroo.Title);
            Assert.Equal(daroo.Title, daroo.Description);



        }
    }
}
