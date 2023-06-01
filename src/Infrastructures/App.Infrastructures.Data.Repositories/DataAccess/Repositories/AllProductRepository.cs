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
    public class AllProductRepository : IAllProductRepository
    {
        private readonly IMapper _mapper;
        private readonly MarketDbContext _context;

        public AllProductRepository(IMapper mapper, MarketDbContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task Active(int allProductId, CancellationToken cancellationToken)
        { var entity = await _context.AllProducts.Where(a => a.Id == allProductId).FirstOrDefaultAsync();
            entity.IsCreated = true;
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task Create(AllProductDto entity, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<AllProduct>(entity);
            await _context.AllProducts.AddAsync(record);
            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                //_loger.LogError("Error in add new HomeService {exception}", ex);
            }
        }

        public async Task DiActive(int allProductId, CancellationToken cancellationToken)
        {
            var entity = await _context.AllProducts.Where(a => a.Id == allProductId).FirstOrDefaultAsync();
            entity.IsCreated = false;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<AllProductDto>> GetAll(int CategoryId, CancellationToken cancellationToken)
        =>  _mapper.Map<List<AllProductDto>>( await _context.Products
            .AsNoTracking()
            .Include(p => p.AllProduct)
            .ThenInclude(a=>a.CategoryId == CategoryId )
            .ToListAsync(cancellationToken));




        public async Task<AllProductDto> GetDatail(int AllProductId, CancellationToken cancellationToken)
        {
            var allProduct = await _context.AllProducts
                .AsNoTracking()
                .Where(a => a.Id == AllProductId)
                .FirstOrDefaultAsync(cancellationToken);

            return _mapper.Map<AllProductDto>(allProduct);
        }

        public async Task HardDelted(int AllProductId, CancellationToken cancellationToken)
        {
            var allproduct = await _context.AllProducts
                .Where(x => x.Id == AllProductId)
                .FirstOrDefaultAsync(cancellationToken);
            _context.Remove(allproduct);
            try
            {
                await _context.SaveChangesAsync(cancellationToken);

            }
            catch (Exception ex)
            {
                //_loger.LogError("Error in HardDelete order {exception}", ex);
            }
        }

        public async Task SoftDelete(int AllProductId, CancellationToken cancellationToken)
        {
            var record = await _context.AllProducts
                .Where(x => x.Id == AllProductId)
                .FirstOrDefaultAsync();
            record.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Update(AllProductDto AllProduct, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<AllProductDto>(_context.Set<AllProductDto>())
                .Where(x => x.Id == AllProduct.Id)
                .FirstOrDefaultAsync();
            _mapper.Map(AllProduct, record);
            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                //_loger.LogError("Error in update HomeService {exception}", ex);
            }
        }
    }
}
