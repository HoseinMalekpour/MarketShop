using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Admins
{
    public interface IImageAppservice
    {
        Task<ImageDto> GetDetail(int imageId, CancellationToken cancellationToken);
        Task<List<ImageDto>> GetProductImages(int productId, CancellationToken cancellationToken);
        Task<List<ImageDto>> GetuserImage(string userId, CancellationToken cancellationToken);
      
        Task Create(string path,bool isProfile, CancellationToken cancellationToken);
        Task Deactivate(int ImageId, CancellationToken cancellationToken);
        Task Active(int ImageId, CancellationToken cancellationToken);
       
    }
}
