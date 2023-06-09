﻿using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Admins
{
    public interface IProductAppservice
    {
        Task<ProductDto> GetDetail(int productId, CancellationToken cancellationToken);
        Task<List<ProductDto>> GetBoothProducts(int boothId, CancellationToken cancellationToken);
        Task<List<ProductDto>> GetCategoryProducts(int CategoryId, CancellationToken cancellationToken);
        Task<List<ProductDto>> GetMCAtegoryProducts(int MCId, CancellationToken cancellationToken);
        Task Create(int unitPrice, int boothId, int allProductId ,CancellationToken cancellationToken);
        Task Deactivate(int producttId, CancellationToken cancellationToken);
        Task Active(int productId, CancellationToken cancellationToken);
        Task Update(ProductDto product, CancellationToken cancellationToken);
    }
}
