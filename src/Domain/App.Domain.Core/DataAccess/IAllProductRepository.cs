using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DataAccess
{
    public interface IAllProductRepository
    {
        Task Active(int allProductId, CancellationToken cancellationToken);
        Task DiActive(int allProductId, CancellationToken cancellationToken);
        Task<List<AllProductDto>> GetAll(int CategoryId, CancellationToken cancellationToken);
        Task<AllProductDto> GetDatail(int AllProductId, CancellationToken cancellationToken);
        Task Create(AllProductDto entity, CancellationToken cancellationToken);
        Task Update(AllProductDto AllProduct, CancellationToken cancellationToken);
        Task SoftDelete(int AllProductId, CancellationToken cancellationToken);
        Task HardDelted(int AllProductId, CancellationToken cancellationToken);
        
    }
}
