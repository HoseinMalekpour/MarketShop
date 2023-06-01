using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Admins
{
    public interface IBidAppservice
    {
        Task Active(int bidId, CancellationToken cancellationToken);
        Task DiActive(int bidId, CancellationToken cancellationToken);
        Task<List<BidDto>> GetAll(int ProductId, CancellationToken cancellationToken);
        Task<List<BidDto>> GetUserBids(string userID, CancellationToken cancellationToken);
        Task<BidDto> GetDatail(int bidId, CancellationToken cancellationToken);
        Task Create(BidDto bid, CancellationToken cancellationToken);
        Task SoftDelete(int bidId, CancellationToken cancellationToken);
        Task HardDelted(int bidId, CancellationToken cancellationToken);
    }
}
