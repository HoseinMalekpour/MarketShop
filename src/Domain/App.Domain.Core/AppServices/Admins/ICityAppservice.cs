using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Admins
{
    public interface ICityAppservice
    {
        Task<CityDto> GetItem(int ItemId, CancellationToken cancellationToken);
        Task<List<CityDto>> GetProvineCities(int ProvinceId, CancellationToken cancellationToken);
        Task Create(string name, int ProvinceId, CancellationToken cancellationToken);
        Task Update(CityDto city, CancellationToken cancellationToken);
        Task Deactivate(int cityId, CancellationToken cancellationToken);
        Task Active(int cityId, CancellationToken cancellationToken);
    }
}
