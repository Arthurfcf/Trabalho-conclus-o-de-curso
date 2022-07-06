using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public abstract class PessoaBaseEntity
    {

        [Key]
        public Guid Id { get; set; }

        public string CPF { get; set; }

        public string Name { get; set; }

        public string Telefone { get; set; }

        public char Sexo { get; set; }

        public string CartaoSus { get; set; }

        public string CEP { get; set; }

        public int NumeroPredial { get; set; }
                
        private DateTime? _createAt;
        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt
        {
            get; set;
        }
    }
}
