using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
   public class MedicoModel : BaseModel 
    {
        private string _crm;

        public string CRM 
        {
            get { return _crm; }
            set { _crm = value; }
        }
        private string _cpf;

        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        private Guid _consulta;

        public Guid Consulta
        {
            get { return _consulta; }
            set { _consulta = value; }
        }

    }
}
