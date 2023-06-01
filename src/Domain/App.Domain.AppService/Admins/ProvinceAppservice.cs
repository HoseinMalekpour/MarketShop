using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.AppServices.Admins;
using App.Domain.Core.DtoModels;

namespace App.Domain.AppService.Admins
{
    public class ProvinceAppservice : IProvinceAppservice
    {
        public Task Active(int provinceId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Create(string name, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Deactivate(int provinceId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ProvinceDto> GetItem(int ItemId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProvinceDto>> GetProvines(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Update(ProvinceDto province, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
