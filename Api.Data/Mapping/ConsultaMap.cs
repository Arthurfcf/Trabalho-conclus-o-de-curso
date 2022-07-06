using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class ConsultaMap : IEntityTypeConfiguration<ConsultaEntity>
    {
        public void Configure(EntityTypeBuilder<ConsultaEntity> builder)
        {
            builder.ToTable("Consultas");

            builder.HasKey(c => c.Id);

            builder.HasIndex(c => c.InicioIsolamentoSocial);

            builder.HasIndex(c => c.PessoaViva);

            builder.HasIndex(c => c.IsolamentoSocial);

            builder.HasIndex(c => c.FimIsolamentoSocial);
        }
    }
}
