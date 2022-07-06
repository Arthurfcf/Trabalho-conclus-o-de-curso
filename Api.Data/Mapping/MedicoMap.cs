using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class MedicoMap : IEntityTypeConfiguration<MedicoEntity>
    {
        public void Configure(EntityTypeBuilder<MedicoEntity> builder)
        {
            builder.ToTable("Medico");

            builder.HasKey(p => p.Id);

            builder.HasIndex(p => p.CRM)
                  .IsUnique();
            builder.Property(p => p.CRM)
                .IsRequired()
                .HasMaxLength(16);

            builder.HasIndex(p => p.CPF)
                   .IsUnique();
            builder.Property(p => p.CPF)
                .IsRequired()
                .HasMaxLength(13);

            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(50);


            builder.HasIndex(p => p.Telefone)
                .IsUnique();
            builder.Property(p => p.Telefone)
                .HasMaxLength(13);

            builder.Property(p => p.Sexo)
                .IsRequired();

            builder.Property(p => p.NumeroPredial)
                .HasMaxLength(12);

            builder.Property(p => p.Sexo)
                .HasMaxLength(2);

            builder.HasOne(m => m.Consulta)
                .WithMany(m => m.Medicos);

        }
    }
}
