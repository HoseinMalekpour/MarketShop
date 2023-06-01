using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels
{
    public class AuctionDto
    {
        public int Id { get; set; }

        public int BoothId { get; set; }

        public int ProductId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int? BestBidId { get; set; }

        public bool? IsCreated { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<BidDto> Bids { get; set; } = new List<BidDto>();

        public virtual ProductDto Product { get; set; } = null!;
    }
}
