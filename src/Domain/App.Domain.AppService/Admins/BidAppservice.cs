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
    public class BidAppservice : IBidAppservice
    {
        private readonly IBidRepository _bidRepository;

        public BidAppservice(IBidRepository bidRepository)
        {
            _bidRepository = bidRepository;
        }

        public async Task<List<BidDto>> GetAll(int ProductId, CancellationToken cancellationToken)
        {
            return await _bidRepository.GetAll(ProductId, cancellationToken);
        }

        public async Task<List<BidDto>> GetUserBids(string userID, CancellationToken cancellationToken)
        {
           return await _bidRepository.GetUserBids(userID, cancellationToken);
        }

        public  async Task HardDelted(int bidId, CancellationToken cancellationToken)
        {
          await  _bidRepository.HardDelted(bidId, cancellationToken);
        }

        public async Task SoftDelete(int bidId, CancellationToken cancellationToken)
        {
            await _bidRepository.SoftDelete(bidId, cancellationToken);
        }

        async Task IBidAppservice.Active(int bidId, CancellationToken cancellationToken)
        {
            await _bidRepository.Active(bidId, cancellationToken);
        }

        async Task IBidAppservice.Create(BidDto bid , CancellationToken cancellationToken)
        {
            bid.CreatedAt = DateTime.Now;
            bid.IsCreated = false;
            bid.IsDeleted= false;
            await _bidRepository.Create(bid, cancellationToken);
        }

        async Task IBidAppservice.DiActive(int bidId, CancellationToken cancellationToken)
        {
           await _bidRepository.DiActive(bidId, cancellationToken);
        }

        async Task<BidDto> IBidAppservice.GetDatail(int bidId, CancellationToken cancellationToken)
        {
           return await _bidRepository.GetDatail(bidId, cancellationToken);
        }

        
        
    }
}
