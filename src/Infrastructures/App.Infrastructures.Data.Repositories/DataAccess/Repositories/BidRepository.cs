using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using AutoMapper;
using App.Infrastructures.Db.SqlServer.Ef.Database;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;

namespace App.Infrastructures.Data.Repositories.DataAccess.Repositories
{
    public class BidRepository : IBidRepository
    {

        private readonly IMapper _mapper;
        private readonly MarketDbContext _context;

        public BidRepository(IMapper mapper, MarketDbContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task Active(int bidId, CancellationToken cancellationToken)
        {
            var bid = await _context.Bids
            .Where(x => x.Id == bidId)
            .FirstOrDefaultAsync();
            bid.IsCreated = true;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Create(BidDto bid, CancellationToken cancellationToken)
        {

            var record = _mapper.Map<Bid>(bid);
            record.CreatedAt = DateTime.Now;

            try
            {
                await _context.Bids.AddAsync(record);
                await _context.SaveChangesAsync(cancellationToken);

            }
            catch (Exception ex)
            {
                //_loger.LogError("Error in add new Order {exception}", ex);
            }

        }

        public async Task DiActive(int bidId, CancellationToken cancellationToken)
        {
            var bid = await _context.Bids
             .Where(x => x.Id == bidId)
             .FirstOrDefaultAsync();
            bid.IsCreated = false;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<BidDto>> GetAll(int ProductId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        public async Task<BidDto> GetDatail(int bidId, CancellationToken cancellationToken)
         => await _context.Bids
          .Where(b => b.Id == bidId)
          .ProjectTo<BidDto>(_mapper.ConfigurationProvider)
          .SingleOrDefaultAsync(cancellationToken);


        public async Task<List<BidDto>> GetUserBids(string userID, CancellationToken cancellationToken)
        {
            return null;
        }
    //=> await _context.Bids
    //    .AsNoTracking()
    //    .Where(b => b.AppUserId == userID)
    //    .ProjectTo<BidDto>(_mapper.ConfigurationProvider)
    //    .ToListAsync(cancellationToken);

        public async Task HardDelted(int bidId, CancellationToken cancellationToken)
        {
            var bid = await _context.Bids
                .Where(x => x.Id == bidId)
                .FirstOrDefaultAsync(cancellationToken);
            _context.Remove(bid);
            try
            {
                await _context.SaveChangesAsync(cancellationToken);

            }
            catch (Exception ex)
            {
                //_loger.LogError("Error in HardDelete order {exception}", ex);
            }
        }

        public async  Task SoftDelete(int bidId, CancellationToken cancellationToken)
        {
            var record = await _context.Bids
               .Where(x => x.Id == bidId)
               .FirstOrDefaultAsync();
            record.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
        }

       
    }
}
