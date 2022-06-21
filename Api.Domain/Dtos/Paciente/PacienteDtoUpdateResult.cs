using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos.Paciente
{
   public class PacienteDtoUpdateResult
    {

        public Guid Id { get; set; }

        public string CPF { get; set; }

        public string Name { get; set; }

        public string Telefone { get; set; }

        public char Sexo { get; set; }

        public string CEP { get; set; }

        public int NumeroPredial { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime UpdateAt { get; set; }

        public char IsolamentoSocial { get; set; }

        public DateTime InicioIsolamentoSocial { get; set; }

        public DateTime FimIsolamentoSocial { get; set; }

        public char PessoaViva { get; set; }

    }
}
