using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Infrastructures.Db.SqlServer.Ef.Database;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace App.Infrastructures.Data.Repositories.DataAccess.Repositories
{
    public class OrderRipository : IOrderRipository
    {
        private readonly IMapper _mapper;
        private readonly MarketDbContext _context;

        public OrderRipository(IMapper mapper, MarketDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task Create(OrderDto order, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Order>(order);
            record.OrderCreatTime = DateTime.Now;
            try
            {
                await _context.Orders.AddAsync(record);
                await _context.SaveChangesAsync(cancellationToken);

            }
            catch (Exception ex)
            {
                //_loger.LogError("Error in add new Order {exception}", ex);
            }
        }

        public async Task<List<OrderDto>> GetAllUser(string userId, CancellationToken cancellationToken)
        { return null; }// => _mapper.Map<List<OrderDto>>(await _context.Orders.
        //    Where(x => x.BuyerUserId == userId)
        //    .ToListAsync(cancellationToken));

        public async Task<OrderDto> GetDatail(int ordeId, CancellationToken cancellationToken)
        => await Task.FromResult(_mapper.Map<OrderDto>(await _context.Orders
             .AsNoTracking()
             .Where(x => x.Id == ordeId)
              .FirstOrDefaultAsync(cancellationToken)));

        public async Task<List<OrderDto>> GetWithBooth(int boothID, CancellationToken cancellationToken)
         => _mapper.Map<List<OrderDto>>(await _context.Orders.
            Where(x => x.BoothId == boothID)
            .ToListAsync(cancellationToken));

        public async Task<List<OrderDto>> GetWithStatus(int statusId, CancellationToken cancellationToken)
         => _mapper.Map<List<OrderDto>>(await _context.Orders.
            Where(x => x.StatusId == statusId)
            .ToListAsync(cancellationToken));

        public async Task HardDelted(int orderId, CancellationToken cancellationToken)
        {
            var order = await _context.Comments
               .Where(x => x.Id == orderId)
               .FirstOrDefaultAsync(cancellationToken);
            _context.Remove(order);
            try
            {
                await _context.SaveChangesAsync(cancellationToken);

            }
            catch (Exception ex)
            {
                //_loger.LogError("Error in HardDelete order {exception}", ex);
            }
        }

        public async Task SoftDelete(int orderId, CancellationToken cancellationToken)
        {
            var comment = await _context.Orders
             .Where(x => x.Id == orderId)
             .FirstOrDefaultAsync();
            comment.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Update(OrderDto order, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<CommentDto>(_context.Set<CommentDto>())
                   .Where(x => x.Id == order.Id).FirstOrDefaultAsync();
            _mapper.Map(order, record);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
