using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.AppServices.Admins;
using App.Domain.Core.DtoModels;
using App.Domain.Core.DataAccess;

namespace App.Domain.AppService.Admins
{
    public class AllProductAppservice : IAllProductAppservice
    {
        private readonly IAllProductRepository _allproductRipository;
       

        public AllProductAppservice(IAllProductRepository allproductRipository)
        {

        
            _allproductRipository = allproductRipository;
          
        }

        public async Task Active(int allProductId, CancellationToken cancellationToken)
        {
         await _allproductRipository.Active(allProductId, cancellationToken);
        }

        public async Task Create(AllProductDto entity, CancellationToken cancellationToken)
        {
           await _allproductRipository.Create(entity, cancellationToken);
        }

        public async Task DiActive(int allProductId, CancellationToken cancellationToken)
        {
           await _allproductRipository.DiActive(allProductId, cancellationToken);
        }

        public async Task<List<AllProductDto>> GetAll(int CategoryId, CancellationToken cancellationToken)
        {
           return await _allproductRipository.GetAll(CategoryId, cancellationToken);
        }

        public async Task<AllProductDto> GetDatail(int AllProductId, CancellationToken cancellationToken)
        {
            return await _allproductRipository.GetDatail(AllProductId, cancellationToken);
        }
         
        public async Task HardDelted(int AllProductId, CancellationToken cancellationToken)
        {
           await _allproductRipository.HardDelted(AllProductId, cancellationToken);
        }

        public async Task SoftDelete(int AllProductId, CancellationToken cancellationToken)
        {
           await _allproductRipository.SoftDelete(AllProductId, cancellationToken);
        }

        public async Task Update(AllProductDto AllProduct, CancellationToken cancellationToken)
        {
           await _allproductRipository.Update(AllProduct, cancellationToken);
        }
    }
}
