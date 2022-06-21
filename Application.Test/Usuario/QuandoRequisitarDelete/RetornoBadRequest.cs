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
    public class RetornoBadRequest
    {

        private UsersController _controller;

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        [Fact(DisplayName = "É possivel Realizar o Delete.")]
        public async Task E_Possivel_Invocar_a_Controller_Delete()
        {
            var serviceMoke = new Mock<IUserService>();
            var nome = Faker.Name.FullName();
            var email = Faker.Internet.Email();

            serviceMoke.Setup(m => m.Delete(It.IsAny<Guid>())).ReturnsAsync(false);
            _controller = new UsersController(serviceMoke.Object);
            _controller.ModelState.AddModelError("Id", "Formato inválido");

            var result = await _controller.Delete(default(Guid));
            Assert.True(result is BadRequestObjectResult);
            Assert.False(_controller.ModelState.IsValid);

        }
    }
}
