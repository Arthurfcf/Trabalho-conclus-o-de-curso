using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos.Medico
{
   public class MedicoDtoUpdateResult
    {
        public Guid Id { get; set; }

        public string CPF { get; set; }

        public string Name { get; set; }

        public string Telefone { get; set; }

        public char Sexo { get; set; }

        public string CEP { get; set; }

        public int NumeroPredial { get; set; }

        public DateTime DataNascimento { get; set; }

        public Guid ConsultaId { get; set; }

        public DateTime UpdateAt { get; set; }

        public string CRM { get; set; }
    }
}
