using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.PacienteModel
{
   public class PacienteModel : BaseModel
    {
       
        private string _cpf;

        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

    }
}
