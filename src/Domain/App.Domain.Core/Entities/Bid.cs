using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class Bid
{
    public int Id { get; set; }

    public int SuggestedPrice { get; set; }

    public int BuyerUserId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool IsCreated { get; set; }

    public virtual ICollection<ProductBid> ProductBids { get; set; } = new List<ProductBid>();
}
