using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DataAccess
{
    public interface IBoothRipository
    {
        Task Active(int boothId, CancellationToken cancellationToken);
        Task DiActive(int boothId, CancellationToken cancellationToken);
        Task<List<BoothDto>> GetCitiesBooth(int cityId, CancellationToken cancellationToken);
        Task<BoothDto> GetDatail(int boothId, CancellationToken cancellationToken);
        Task Create(BoothDto booth, CancellationToken cancellationToken);
        Task<BoothDto> GetUserBooth(string userId, CancellationToken cancellationToken);
        Task<List<BoothDto>> GetCategoriesBooth(int categoryId, CancellationToken cancellationToken);
        Task Update(BoothDto booth, CancellationToken cancellationToken);
        Task SoftDelete(int boothId, CancellationToken cancellationToken);
        Task HardDelted(int boothId, CancellationToken cancellationToken);

    }
}
