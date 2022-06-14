using Api.Data.Context;
using Api.Data.Implementations;
using Api.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest
{
    public class UsuarioCrudCompleto : BaseTest, IClassFixture<Dbteste>
    {
        private ServiceProvider _serviceProvider;

        public UsuarioCrudCompleto(Dbteste dbteste)
        {
            _serviceProvider = dbteste.ServiceProvider;
        }

        [Fact(DisplayName = "CRUD de usuario")]
        [Trait("CRUD", "UserEntity")]
        public async Task E_Possivel_realizar_Crud_Usuario()
        {
            using ( var context = _serviceProvider.GetService<MyContext>())
            {
                UserImplementation _repositorio = new UserImplementation(context);
                UserEntity _entity = new UserEntity
                {
                    Email = "testeUni@gmail.com",
                    Name = "testeUni"
                };
                var _registroCriado = await _repositorio.InsertAsync(_entity);
                Assert.NotNull(_registroCriado);
                Assert.Equal("testeUni@gmail.com", _registroCriado.Email);
                Assert.Equal("testeUni", _registroCriado.Name);
                Assert.False(_registroCriado.Id == Guid.Empty);
            }
        }
    }
}
