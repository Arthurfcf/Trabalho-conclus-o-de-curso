using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Seeds
{
   public static class PacienteSeeds
    {
        public static void Pacientes (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PacienteEntity>().HasData(
                new PacienteEntity()
                {
                    Id = new Guid("39a607e6-e9a7-42a5-806b-25c541a35430"),
                    Name = "Arthur Fernando",
                    CPF = "33333333333",
                    Telefone = "11111111111",
                    Sexo = 'M',
                    CEP = "80250180",
                    NumeroPredial = 3334455,
                   

                },
                new PacienteEntity()
                {
                    Id = new Guid("85e5360e-6315-43c5-9a57-ed0098afc09e"),
                    Name = "Daniel Paes",
                    CPF = "33333333333",
                    Telefone = "11111111111",
                    Sexo = 'M',
                    CEP = "80250180",
                    NumeroPredial = 3334455,
                  
                    CreateAt = DateTime.UtcNow
                },
                new PacienteEntity() {

                    Id = new Guid("da5e805d-fef8-4faa-817a-d8c45b1dffde"),
                    Name = "Nycolas ",
                    CPF = "33333333333",
                    Telefone = "11111111111",
                    Sexo = 'M',
                    CEP = "80250112",
                    NumeroPredial = 3334455,
                    CreateAt = DateTime.UtcNow
                    
                },
                new PacienteEntity()
                {

                    Id = new Guid("0f268eac-7bd2-4064-be3c-f11ce6cd85e4"),
                    Name = "João ",
                    CPF = "44444444444",
                    Telefone = "11111111111",
                    Sexo = 'M',
                    CEP = "80250111",
                    NumeroPredial = 3334455,
                    CreateAt = DateTime.UtcNow

                }, new PacienteEntity()
                {

                    Id = new Guid("28198310-1418-4ec0-be72-5457553435e6"),
                    Name = "Maria ",
                    CPF = "44444444444",
                    Telefone = "11111111111",
                    Sexo = 'F',
                    CEP = "80250111",
                    NumeroPredial = 3334455,
                    CreateAt = DateTime.UtcNow

                });
        }
    }
}
