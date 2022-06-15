using Api.Domain.Interfaces.Services.User;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ServiceTest.Usuario
{
    public class QuandoForExecutadoUpdate : UsuariosTestes
    {
        private IUserService _service;

        private Mock<IUserService> _serviceMock;


        [Fact(DisplayName = "É Possivel Executar o Método CREATE.")]

        public async Task E_Possivel_Executar_Metodo_Create()
        {

            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(x => x.Post(userDtoCreate)).ReturnsAsync(userDtoCreateResult);
            _service = _serviceMock.Object;

            var result = await _service.Post(userDtoCreate);
            Assert.NotNull(result);
            Assert.Equal(NomeUsuario, result.Name);
            Assert.Equal(EmailUsuario, result.Email);

            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(x => x.Put(userDtoUpdate)).ReturnsAsync(userDtoUpdateResult);
            _service = _serviceMock.Object;

            var resultUpdate = await _service.Put(userDtoUpdate);
            Assert.NotNull(resultUpdate);
            Assert.Equal(NomeAlterado, resultUpdate.Name);
            Assert.Equal(EmailAlterado, resultUpdate.Email);
        }
    }
}
