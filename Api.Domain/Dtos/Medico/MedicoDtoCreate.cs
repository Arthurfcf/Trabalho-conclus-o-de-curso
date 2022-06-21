using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Dtos.Medico
{
  public  class MedicoDtoCreate
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(11, ErrorMessage = "Formato de ter no máximo 11 caracteres ")]
        [MinLength(11, ErrorMessage = "Formato deve ter no minimo 11 caracteres")]
        [Range(0, int.MaxValue, ErrorMessage = "Não pode ser número negativo negativo")]
        public string CPF { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Formato de ter no máximo 11 caracteres ")]
        [MinLength(2, ErrorMessage = "Formato deve ter no minimo 11 caracteres")]
        public string Name { get; set; }

        [Required]
        [MaxLength(11, ErrorMessage = "Formato de ter no máximo 11 caracteres ")]
        [MinLength(11, ErrorMessage = "Formato deve ter no minimo 11 caracteres")]
        [Range(0, int.MaxValue, ErrorMessage = "Não pode ser número negativo negativo")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Formato deve ser M para masculino e F para feminino")]
        public char Sexo { get; set; }

        [Required]
        [MaxLength(8, ErrorMessage = "Formato de ter no máximo 8 caracteres ")]
        [MinLength(8, ErrorMessage = "Formato deve ter no minimo 8 caracteres")]
        [Range(0, int.MaxValue, ErrorMessage = "Não pode ser número negativo negativo")]
        public string CEP { get; set; }

        public int NumeroPredial { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        public Guid ConsultaId { get; set; }

        public string CRM { get; set; }

    }
}
