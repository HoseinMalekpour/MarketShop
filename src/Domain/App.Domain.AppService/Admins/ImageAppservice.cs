using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.AppServices.Admins;
using App.Domain.Core.DtoModels;

namespace App.Domain.AppService.Admins
{
    public class ImageAppservice : IImageAppservice
    {
        public Task Active(int ImageId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Create(string path, bool isProfile, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Deactivate(int ImageId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ImageDto> GetDetail(int imageId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ImageDto>> GetProductImages(int productId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ImageDto>> GetuserImage(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
