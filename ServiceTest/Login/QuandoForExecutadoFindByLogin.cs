using Api.Domain.Dtos;
using Api.Domain.Interfaces.Services.User;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ServiceTest.Login
{
    public class QuandoForExecutadoFindByLogin
    {
        private ILoginService _service;

        private Mock<ILoginService> _serviceMock;

        [Fact(DisplayName = "É Possivel executar o Método FinByLogin")]

        public async Task E_Pssivel_Executar_Metodo_FindByLogin()
        {
            var email = Faker.Internet.Email();

            var objetoRetorno = new
            {
                authenticated = true,
                create = DateTime.Now,
                expiration = DateTime.UtcNow.AddHours(8),
                acessToken = Guid.NewGuid(),
                userName = email,
                name = Faker.Name.FullName(),
                message = "Usuário logado com sucesso"

            };

            var loginDto = new LoginDto
            {
                Email = email,

            };
            _serviceMock = new Mock<ILoginService>();
            _serviceMock.Setup(x => x.FindByLogin(loginDto)).ReturnsAsync(objetoRetorno);
            _service = _serviceMock.Object;

            var result = await _service.FindByLogin(loginDto);
            Assert.NotNull(result);

        }
    }
}


