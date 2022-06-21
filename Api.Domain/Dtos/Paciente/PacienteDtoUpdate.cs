﻿using Domain.Dtos.Consulta;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos.Paciente
{
   public class PacienteDtoUpdate
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

        public ConsultaDto ConsultaDto { get; set; }
    }
}
