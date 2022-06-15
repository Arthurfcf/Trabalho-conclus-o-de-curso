using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace ServiceTest.AutoMapper
{
    public class UsuarioMapper : BaseTesteService
    {
        [Fact(DisplayName = "É Possível Mapear os Modelos")]
        public void E_Possivel_Mapear_os_Modelos()
        {
            var model = new UserModel
            {
                Id = Guid.NewGuid(),
                Name = Faker.Name.FullName(),
                Email = Faker.Internet.Email(),
                CreateAt = DateTime.Now,
                UpdateAt = DateTime.Now
            };

            var listaEntity = new List<UserEntity>();
            for (int i = 0; i < 5; i++)
            {
                var item = new UserEntity
                {
                    Id = Guid.NewGuid(),
                    Name = Faker.Name.FullName(),
                    Email = Faker.Internet.Email(),
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now
                };
                listaEntity.Add(item);
            }

            var entity = Mapper.Map<UserEntity>(model);
            Assert.Equal(entity.Id, model.Id);
            Assert.Equal(entity.Name, model.Name);
            Assert.Equal(entity.Email, model.Email);
            Assert.Equal(entity.CreateAt, model.CreateAt);
            Assert.Equal(entity.UpdateAt, model.UpdateAt);

            var userDto = Mapper.Map<UserDto>(entity);
            Assert.Equal(userDto.Id, entity.Id);
            Assert.Equal(userDto.Name, entity.Name);
            Assert.Equal(userDto.Email, entity.Email);
            Assert.Equal(userDto.CreateAt, entity.CreateAt);

            var listaDto = Mapper.Map<List<UserDto>>(listaEntity);
            Assert.True(listaDto.Count() == listaDto.Count());
            for (int i = 0; i < listaDto.Count(); i++)
            {
                Assert.Equal(listaDto[i].Id, listaEntity[i].Id);
                Assert.Equal(listaDto[i].Name, listaEntity[i].Name);
                Assert.Equal(listaDto[i].Email, listaEntity[i].Email);
                Assert.Equal(listaDto[i].CreateAt, listaEntity[i].CreateAt);
            }

            var userDtoCreateResult = Mapper.Map<UserDtoCreateResult>(entity);
            Assert.Equal(userDtoCreateResult.Id, model.Id);
            Assert.Equal(userDtoCreateResult.Name, model.Name);
            Assert.Equal(userDtoCreateResult.Email, model.Email);
            Assert.Equal(userDtoCreateResult.CreateAt, model.CreateAt);

            var userDtoUpdateResult = Mapper.Map<UserDtoUpdateResult>(entity);
            Assert.Equal(userDtoUpdateResult.Id, model.Id);
            Assert.Equal(userDtoUpdateResult.Name, model.Name);
            Assert.Equal(userDtoUpdateResult.Email, model.Email);
            Assert.Equal(userDtoUpdateResult.UpdateAt, model.UpdateAt);

            var userModel = Mapper.Map<UserModel>(userDto);
            Assert.Equal(userModel.Id, userDto.Id);
            Assert.Equal(userModel.Name, userDto.Name);
            Assert.Equal(userModel.Email, userDto.Email);
            Assert.Equal(userModel.CreateAt, userDto.CreateAt);

            var UserDtoCreate = Mapper.Map<UserDtoCreate>(userModel);
            Assert.Equal(UserDtoCreate.Name, userModel.Name);
            Assert.Equal(UserDtoCreate.Email, userModel.Email);

            var UserDtoUpdate = Mapper.Map<UserDtoUpdate>(userModel);
            Assert.Equal(UserDtoUpdate.Id, userModel.Id);
            Assert.Equal(UserDtoUpdate.Name, userModel.Name);
            Assert.Equal(UserDtoUpdate.Email, userModel.Email);
            
        }

    }
}
