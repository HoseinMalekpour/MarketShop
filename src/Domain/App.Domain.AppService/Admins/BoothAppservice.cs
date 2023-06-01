using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.AppServices.Admins;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;

namespace App.Domain.AppService.Admins
{
    public class BoothAppservice : IBoothAppservice
    {
        private readonly IBoothRipository _boothRipository;

        public BoothAppservice(IBoothRipository boothRipository)
        {
            _boothRipository = boothRipository;
        }

        public async Task Active(int boothId, CancellationToken cancellationToken)
        {
           await _boothRipository.Active(boothId, cancellationToken);
        }

        public async Task Create(BoothDto booth, CancellationToken cancellationToken)
        {
           await _boothRipository.Create(booth, cancellationToken);
        }

        public async Task DiActive(int boothId, CancellationToken cancellationToken)
        {
          await _boothRipository.DiActive(boothId, cancellationToken);
        }

        public async Task<List<BoothDto>> GetCategoriesBooth(int categoryId, CancellationToken cancellationToken)
        {
          return await _boothRipository.GetCategoriesBooth(categoryId, cancellationToken);
        }

        public async Task<List<BoothDto>> GetCitiesBooth(int cityId, CancellationToken cancellationToken)
        {
           return await _boothRipository.GetCitiesBooth(cityId, cancellationToken);
        }

        public async Task<BoothDto> GetDatail(int boothId, CancellationToken cancellationToken)
        {
           return await _boothRipository.GetDatail(boothId, cancellationToken);
        }

        public async Task<BoothDto> GetUserBooth(string userId, CancellationToken cancellationToken)
        {
          return await _boothRipository.GetUserBooth(userId, cancellationToken);
        }

        public async Task HardDelted(int boothId, CancellationToken cancellationToken)
        {
            await _boothRipository.HardDelted(boothId, cancellationToken);
        }

        public async Task SoftDelete(int boothId, CancellationToken cancellationToken)
        {
            await _boothRipository.SoftDelete(boothId, cancellationToken);
        }

        public async Task Update(BoothDto booth, CancellationToken cancellationToken)
        {
            await _boothRipository.Update(booth, cancellationToken);
        }
    }
}
