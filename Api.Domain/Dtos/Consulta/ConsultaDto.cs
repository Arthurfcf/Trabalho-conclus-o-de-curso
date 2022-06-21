using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos.Consulta
{
   public class ConsultaDto
    {
        public Guid Id { get; set; }

        public char IsolamentoSocial { get; set; }

        public DateTime InicioIsolamentoSocial { get; set; }

        public DateTime FimIsolamentoSocial { get; set; }

        public char PessoaViva { get; set; }

       
    }
}
