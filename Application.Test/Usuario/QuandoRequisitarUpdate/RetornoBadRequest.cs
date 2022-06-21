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

namespace Application.Test.Usuario.QuandoRequisitarUpdate
{
   public class RetornoBadRequest
    {

        private UsersController _controller;

        [Fact(DisplayName = "É possivel Realizar o Update.")]
        public async Task E_Possivel_Invocar_a_Controller_UpdateBadRequest()
        {
            var serviceMoke = new Mock<IUserService>();
            var nome = Faker.Name.FullName();
            var email = Faker.Internet.Email();


            serviceMoke.Setup(m => m.Put(It.IsAny<UserDtoUpdate>())).ReturnsAsync(
                new UserDtoUpdateResult
                {
                    Id = Guid.NewGuid(),
                    Name = nome,
                    Email = email,
                    UpdateAt = DateTime.UtcNow

                });
            _controller = new UsersController(serviceMoke.Object);
            _controller.ModelState.AddModelError("Email", "É um campo obrigatorio");

            var userDtoUpdate = new UserDtoUpdate
            {
                Id = Guid.NewGuid(),
                Name = nome,
                Email = email
            };

            var result = await _controller.Put(userDtoUpdate);
            Assert.True(result is BadRequestObjectResult);
            Assert.False(_controller.ModelState.IsValid);
            
        }
    }
}
