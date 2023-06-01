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

namespace App.Infrastructures.Data.Repositories.DataAccess.Repositories
{
    public class BoothRipository:IBoothRipository
    {

        private readonly IMapper _mapper;
        private readonly MarketDbContext _context;

        public BoothRipository(IMapper mapper, MarketDbContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task Active(int boothId, CancellationToken cancellationToken)
        {
            var booth = await _context.Booths
             .Where(x => x.Id == boothId)
             .FirstOrDefaultAsync();
            booth.IsCreated = true;
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task DiActive(int boothId, CancellationToken cancellationToken)
        {
            var booth = await _context.Booths
            .Where(x => x.Id == boothId)
            .FirstOrDefaultAsync();
            booth.IsCreated = false;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Create(BoothDto booth, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Booth>(booth);
            record.CreatedAt = DateTime.Now;
            record.IsCreated = false;
            try
            {
                await _context.Booths.AddAsync(record);
                await _context.SaveChangesAsync(cancellationToken);

            }
            catch (Exception ex)
            {
                //_loger.LogError("Error in add new Order {exception}", ex);
            }
        }
       
        public async Task<List<BoothDto>> GetCitiesBooth(int cityId, CancellationToken cancellationToken)
          => _mapper.Map<List<BoothDto>>(await _context.Booths
            .AsNoTracking()
            .Include(b=>b.CityId == cityId)
            .ToListAsync(cancellationToken));

        public Task<List<BoothDto>> GetCategoriesBooth(int categoryId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<BoothDto> GetUserBooth(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task HardDelted(int boothId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task SoftDelete(int boothId, CancellationToken cancellationToken)
        {
            var record = await _context.Booths
                .Where(x => x.Id == boothId)
                .FirstOrDefaultAsync();
            record.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Update(BoothDto booth, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<BoothDto>(_context.Set<AllProductDto>())
               .Where(x => x.Id == booth.Id)
               .FirstOrDefaultAsync();
            _mapper.Map(booth, record);
            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                //_loger.LogError("Error in update HomeService {exception}", ex);
            }
        }

        public async Task<BoothDto> GetDatail(int boothId, CancellationToken cancellationToken)
       => await Task.FromResult(_mapper.Map<BoothDto>(await _context.Booths
             .AsNoTracking()
             .Where(x => x.Id == boothId)
              .FirstOrDefaultAsync(cancellationToken)));
    }
}
