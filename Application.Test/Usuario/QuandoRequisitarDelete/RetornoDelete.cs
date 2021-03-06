using Api.Application.Controllers;
using Api.Domain.Dtos.User;
using Api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.Test.Usuario.QuandoRequisitarDelete
{
    public class RetornoDelete
    {
        private UsersController _controller;

        [Fact(DisplayName = "É possivel Realizar o Delete.")]
        public async Task E_Possivel_Invocar_a_Controller_Delete()
        {
            var serviceMoke = new Mock<IUserService>();

            serviceMoke.Setup(m => m.Delete(It.IsAny<Guid>())).ReturnsAsync(true);
            _controller = new UsersController(serviceMoke.Object);

            var result = await _controller.Delete(Guid.NewGuid());
            Assert.True(result is OkObjectResult);

            var resultValue = ((OkObjectResult)result).Value;
            Assert.NotNull(resultValue);
            Assert.True((Boolean) resultValue);

        }
    }
}
