using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class PacienteMap : IEntityTypeConfiguration<PacienteEntity>
    {
        public void Configure(EntityTypeBuilder<PacienteEntity> builder)
        {
            builder.ToTable("Pacientes");

            builder.HasKey(p => p.Id);

            builder.HasIndex(p => p.CPF)
                   .IsUnique();
            builder.Property(p => p.CPF)
                .IsRequired()
                .HasMaxLength(13);

            builder.HasIndex(p => p.Name);
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(50);


            builder.HasIndex(p => p.Telefone)
                .IsUnique();
            builder.Property(p => p.Telefone)
                .HasMaxLength(13);

            builder.HasIndex(p => p.Sexo);
            builder.Property(p => p.Sexo)
                .IsRequired();

            builder.HasIndex(p => p.NumeroPredial);
            builder.Property(p => p.NumeroPredial)
                .HasMaxLength(12);

            builder.Property(p => p.Sexo)
                .HasMaxLength(2);

        }
    }
}
