using Domain.Dtos.Consulta;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;

namespace Domain.Interfaces.Consulta
{
  public  interface IConsultaService
    {
        Task<ConsultaDto> Get(Guid id);

        Task<IEnumerable<ConsultaDto>> GetAll();



    }
}
