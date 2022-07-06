using Domain.Dtos.Medico;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Medico
{
   public interface IMedicoService 
    {
        Task<MedicoDto> Get(string crm);

        Task<MedicoDtoUpdate> Put(MedicoDtoUpdate medico);

        Task<IEnumerable<MedicoDto>> GetAll();

        Task<MedicoDto> GetName(string name);

        Task<MedicoDtoCreateResult> Post(MedicoDtoCreate medico);

        Task<bool> Delete(Guid id);
    }
}
