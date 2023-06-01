using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Admins
{
    public interface IProvinceAppservice
    {
        Task<ProvinceDto> GetItem(int ItemId, CancellationToken cancellationToken);
        Task<List<ProvinceDto>> GetProvines( CancellationToken cancellationToken);
        Task Create(string name, CancellationToken cancellationToken);
        Task Update(ProvinceDto province, CancellationToken cancellationToken);
        Task Deactivate(int provinceId, CancellationToken cancellationToken);
        Task Active(int provinceId, CancellationToken cancellationToken);
    }
}
