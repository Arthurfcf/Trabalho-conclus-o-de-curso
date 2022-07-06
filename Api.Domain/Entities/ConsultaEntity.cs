using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ConsultaEntity : BaseEntity
    {
       
        public char IsolamentoSocial { get; set; }

        public DateTime InicioIsolamentoSocial { get; set; }

        public DateTime FimIsolamentoSocial { get; set; }

        public char PessoaViva { get; set; }

        public IEnumerable <PacienteEntity> Pacientes { get; set; }

        public IEnumerable <MedicoEntity> Medicos { get; set; }

    }
   
}
