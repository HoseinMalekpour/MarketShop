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
    public class CategoryRipository:ICategoryRipository
    {
        private readonly IMapper _mapper;
        private readonly MarketDbContext _context;

        public CategoryRipository(IMapper mapper, MarketDbContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task Create(CategoryDto category, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDto>> GetAll(int motherCategoryId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetDatail(int categoryId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task HardDelted(int categoryId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SoftDelete(int categoryId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Update(CategoryDto categor, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
