using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Admins
{
    public interface IOrderAppservice
    {
        Task<List<OrderDto>> GetAllUser(string userId, CancellationToken cancellationToken);
        Task<List<OrderDto>> GetWithStatus(int statusId, CancellationToken cancellationToken);
        Task<List<OrderDto>> GetWithBooth(int boothID, CancellationToken cancellationToken);
        Task<OrderDto> GetDatail(int ordeId, CancellationToken cancellationToken);
        Task Create(OrderDto order, CancellationToken cancellationToken);
        Task Update(OrderDto order, CancellationToken cancellationToken);
        Task SoftDelete(int orderId, CancellationToken cancellationToken);
        Task HardDelted(int orderId, CancellationToken cancellationToken);
    }
}
