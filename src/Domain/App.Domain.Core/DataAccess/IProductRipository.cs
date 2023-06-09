﻿using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DataAccess
{
    public interface IProductRipository
    {
        Task Active(ProductDto product, CancellationToken cancellationToken);
        Task DiActive(ProductDto product, CancellationToken cancellationToken);
        Task<List<ProductDto>> GetAll(int boothId, CancellationToken cancellationToken);
        Task<List<ProductDto>> GetAllFromCategory(int categoryId, CancellationToken cancellationToken);
        Task<ProductDto> GetDatail(int productId, CancellationToken cancellationToken);
        Task Create(ProductDto product, CancellationToken cancellationToken);
        Task Update(ProductDto product, CancellationToken cancellationToken);
        Task SoftDelete(int productId, CancellationToken cancellationToken);
        Task HardDelted(int productId, CancellationToken cancellationToken);
    }
}
