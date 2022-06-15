using Api.Domain.Dtos.User;
using Api.Domain.Interfaces.Services.User;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ServiceTest.Usuario
{
    public class QuandoForExecutadoGetAll : UsuariosTestes
    {

        private IUserService _service;

        private Mock<IUserService> _serviceMock;


        [Fact(DisplayName = "É Possivel Executar o Metodo GETAll.")]

        public async Task E_Possivel_Executar_Metodo_GetAll()
        {

            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(x => x.GetAll()).ReturnsAsync(listaUserDto);
            _service = _serviceMock.Object;

            var result = await _service.GetAll();
            Assert.NotNull(result);
            Assert.True(result.Count() == 10);

            var _listResult = new List<UserDto>();
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(x => x.GetAll()).ReturnsAsync(_listResult.AsEnumerable);
            _service = _serviceMock.Object;

            var _resultEmpaty = await _service.GetAll();
            Assert.True(_resultEmpaty.Count() == 0);
        }
    }
}
