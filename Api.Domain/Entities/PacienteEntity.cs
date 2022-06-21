using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
   public class PacienteEntity : BaseEntity
    {

       
        [Required]
        [MaxLength(11, ErrorMessage = "Formato de ter no máximo 11 caracteres ")]
        [MinLength(11, ErrorMessage = "Formato deve ter no minimo 11 caracteres")]
        public string CPF { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Formato deve ter no máximo 50 carcateres")]
        [MinLength(2, ErrorMessage = "Formato deve ter no minimo 2 caracteres")]
        public string Name { get; set; }
        [Required]
        [MaxLength(11, ErrorMessage = "Formato de ter no máximo 11 caracteres ")]
        [MinLength(11, ErrorMessage = "Formato deve ter no minimo 11 caracteres")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Formato deve ser M para masculino e F para feminino")]
        public char Sexo { get; set; }
        [Required]
        [MaxLength(8, ErrorMessage = "Formato de ter no máximo 8 caracteres ")]
        [MinLength(8, ErrorMessage = "Formato deve ter no minimo 8 caracteres")]
        public string CEP { get; set; }

        public int NumeroPredial { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        public Guid ConsultaId { get; set; }

        public ConsultaEntity Consulta { get; set; }


        public char IsolamentoSocial { get; set; }

        public DateTime InicioIsolamentoSocial { get; set; }

        public DateTime FimIsolamentoSocial { get; set; }

        public char PessoaViva { get; set; }

    }
}
