using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Admins
{
    public interface IMotherCategoryAppservice
    {
        Task<MothersCategoryDto> GetDetail(int Id, CancellationToken cancellationToken);
        Task<List<MothersCategoryDto>> GetAll(CancellationToken cancellationToken);
        Task Create(string title , CancellationToken cancellationToken);
        Task Update(MothersCategoryDto entity, CancellationToken cancellationToken);
        Task Deactivate(int Id, CancellationToken cancellationToken);
        Task Active(int Id, CancellationToken cancellationToken);
        
    }
}
