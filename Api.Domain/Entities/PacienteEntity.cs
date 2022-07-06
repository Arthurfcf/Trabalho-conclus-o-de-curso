using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
   public class PacienteEntity : PessoaBaseEntity
    {

        public string NumeroProtocoloAtendimento { get; set; }

        public Guid ConsultaId { get; set; }

        public ConsultaEntity Consulta { get; set; }

    }
}
