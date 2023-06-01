using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.AppServices.Admins;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;

namespace App.Domain.AppService.Admins
{
    public class OrderAppservice : IOrderAppservice
    {
        private readonly IOrderRipository _orderRipository;

        public OrderAppservice(IOrderRipository orderRipository)
        {
            _orderRipository = orderRipository;
        }

        public async Task<List<OrderDto>> GetAllUser(string userId, CancellationToken cancellationToken)
        {
         return await _orderRipository.GetAllUser(userId , cancellationToken);
        }

        public async Task<List<OrderDto>> GetWithStatus(int statusId, CancellationToken cancellationToken)
        {
          return await _orderRipository.GetWithStatus(statusId , cancellationToken); 
        }

        public async Task<List<OrderDto>> GetWithBooth(int boothID, CancellationToken cancellationToken)
        {
           return await _orderRipository.GetWithBooth(boothID , cancellationToken);
        }

        public async Task<OrderDto> GetDatail(int ordeId, CancellationToken cancellationToken)
        {
          return await _orderRipository.GetDatail(ordeId , cancellationToken);
        }

        public async Task Create(OrderDto order, CancellationToken cancellationToken)
        {
           await _orderRipository.Create(order , cancellationToken);
        }

        public async Task Update(OrderDto order, CancellationToken cancellationToken)
        {
            await _orderRipository.Update(order , cancellationToken);
        }

        public async Task SoftDelete(int orderId, CancellationToken cancellationToken)
        {
            await _orderRipository.SoftDelete(orderId , cancellationToken);
        }

        public async Task HardDelted(int orderId, CancellationToken cancellationToken)
        {
            await _orderRipository.HardDelted(orderId , cancellationToken); 
        }

        
        
    }
}
