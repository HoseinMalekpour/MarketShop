using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class ProductBid
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int BidId { get; set; }

    public virtual Bid Bid { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
