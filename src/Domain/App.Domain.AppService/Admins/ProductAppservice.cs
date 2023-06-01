using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.AppServices.Admins;
using App.Domain.Core.DtoModels;

namespace App.Domain.AppService.Admins
{
    public class ProductAppservice : IProductAppservice
    {
        public Task Active(int productId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Create(int unitPrice, int boothId, int allProductId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Deactivate(int producttId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDto>> GetBoothProducts(int boothId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDto>> GetCategoryProducts(int CategoryId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetDetail(int productId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDto>> GetMCAtegoryProducts(int MCId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Update(ProductDto product, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
