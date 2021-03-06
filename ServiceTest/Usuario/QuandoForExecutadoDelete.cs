using Api.Domain.Interfaces.Services.User;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ServiceTest.Usuario
{
    public class QuandoForExecutadoDelete : UsuariosTestes
    {
        private IUserService _service;

        private Mock<IUserService> _serviceMock;


        [Fact(DisplayName = "É Possivel Executar o Método DELETE.")]

        public async Task E_Possivel_Executar_Metodo_DELETE()
        {

            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(x => x.Delete(IdUsuario))
                .ReturnsAsync(true);
            _service = _serviceMock.Object;

            var deletado = await _service.Delete(IdUsuario);
            Assert.True(deletado);


            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(x => x.Delete(It.IsAny<Guid>()))
                .ReturnsAsync(false);
            _service = _serviceMock.Object;
            deletado = await _service.Delete(Guid.NewGuid());
            Assert.False(deletado); 
        }
    }
}
