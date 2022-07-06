using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;


namespace Data.Seeds
{
    public static class MedicoSeeds
    {
        public static void Medico (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicoEntity>().HasData(
                new MedicoEntity()
                {
                    Id = new Guid("f097bd52-32a8-4a90-b230-fb52bcf23527"),
                    Name = "Camila",
                    CRM = "4444444444444",
                    CPF = "33333333333",
                    Telefone = "11111111111",
                    Sexo = 'M',
                    CEP = "80250180",
                    NumeroPredial = 3334455,
                    CreateAt = DateTime.UtcNow
                   
                },
                 new MedicoEntity()
                 {
                     Id = new Guid("a5a70e53-1ca1-47fe-b0c5-85238251958e"),
                     Name = "José",
                     CRM = "5555555555555",
                     CPF = "33333333333",
                     Telefone = "11111111111",
                     Sexo = 'M',
                     CEP = "80250180",
                     NumeroPredial = 3334455,
                     CreateAt = DateTime.UtcNow
                 });
        }
          
    }
}
