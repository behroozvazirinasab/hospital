using H.DataMdel.ViewModel;
using HospitalSystem.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1.ControllerTest
{
    public class DaroControllerTest
    {
        [Fact]
        public void Should_Return_Daro_Results()
        {
            //Arrange
            var loggerMock = new Mock<IDaroService<DaroController>>();
            var controller = new DaroController(loggerMock.Object);
            //Act
            var result = controller.CreateDaro();

            //Assert            
            result.ShouldNotBeNull();
            result.Count().ShouldBeGreaterThan(1);


        }
    }
}
