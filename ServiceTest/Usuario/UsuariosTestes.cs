using Api.Domain.Dtos.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceTest.Usuario
{
    public class UsuariosTestes
    {
        public static string NomeUsuario { get; set; }
        
        public static string EmailUsuario { get; set; }

        public static string NomeAlterado { get; set; }

        public static string EmailAlterado { get; set; }

        public static Guid IdUsuario { get; set; }

        public List<UserDto> listaUserDto = new List<UserDto>();

        public UserDto userDto;

        public UserDtoCreate userDtoCreate;

        public UserDtoCreateResult userDtoCreateResult;

        public UserDtoUpdate userDtoUpdate;

        public UserDtoUpdateResult userDtoUpdateResult;

        public UsuariosTestes()
        {
            IdUsuario = Guid.NewGuid();
            NomeUsuario = Faker.Name.FullName();
            EmailUsuario = Faker.Internet.Email();
            NomeAlterado = Faker.Name.FullName();
            EmailAlterado = Faker.Internet.Email();

            for (int i = 0; i < 10; i++)
            {
                var dto = new UserDto()
                {
                    Id = Guid.NewGuid(),
                    Name = Faker.Name.FullName(),
                    Email = Faker.Internet.Email(),
                };
                listaUserDto.Add(dto);

                userDto = new UserDto
                {
                    Id = IdUsuario,
                    Name = NomeUsuario,
                    Email = EmailUsuario
                };
                userDtoCreate = new UserDtoCreate
                {
                    Name = NomeUsuario,
                    Email = EmailUsuario
                };

                userDtoCreateResult = new UserDtoCreateResult
                {
                    Id = IdUsuario,
                    Name = NomeUsuario,
                    Email = EmailUsuario,
                    CreateAt=DateTime.UtcNow
                };

                userDtoUpdate = new UserDtoUpdate
                {
                    Id = IdUsuario,
                    Name = NomeAlterado,
                    Email = EmailAlterado
                };

                userDtoUpdateResult = new UserDtoUpdateResult
                {
                    Id= IdUsuario,
                    Name = NomeAlterado,
                    Email = EmailAlterado,
                    UpdateAt = DateTime.UtcNow
                };
            }
        }
    }
}
