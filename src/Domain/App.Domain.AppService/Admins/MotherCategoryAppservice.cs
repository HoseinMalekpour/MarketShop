using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.AppServices.Admins;
using App.Domain.Core.DtoModels;

namespace App.Domain.AppService.Admins
{
    public class MotherCategoryAppservice : IMotherCategoryAppservice
    {
        public Task Active(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Create(string title, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Deactivate(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<MothersCategoryDto>> GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<MothersCategoryDto> GetDetail(int Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Update(MothersCategoryDto entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
