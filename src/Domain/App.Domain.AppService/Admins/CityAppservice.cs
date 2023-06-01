using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.AppServices.Admins;
using App.Domain.Core.DtoModels;

namespace App.Domain.AppService.Admins
{
    internal class CityAppservice : ICityAppservice
    {
        public Task Active(int cityId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Create(string name, int ProvinceId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Deactivate(int cityId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<CityDto> GetItem(int ItemId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<CityDto>> GetProvineCities(int ProvinceId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Update(CityDto city, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
