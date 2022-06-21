using Domain.Dtos.Paciente;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Paciente
{
   public interface IPacienteService
    {
        
        Task<PacienteDto> Get(string cpf);

        Task<PacienteDtoUpdateResult> Put(PacienteDtoUpdate paciente);

        Task<IEnumerable<PacienteDto>> GetAll();

        Task<PacienteDto> GetName(string name);
        
        Task<PacienteDtoCreateResult> Post(PacienteDtoCreate paciente);
        
        Task<bool> Delete(Guid id);
    }
}
