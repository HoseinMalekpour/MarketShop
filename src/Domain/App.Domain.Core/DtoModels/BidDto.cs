using System;
using System.Collections.Generic;

namespace App.Domain.Core.DtoModels;

public partial class BidDto
{
    public int Id { get; set; }

    public int SuggestedPrice { get; set; }

    public string BuyerUserId { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool? IsCreated { get; set; }

    public int BidId { get; set; }

    public virtual AuctionDto BidNavigation { get; set; } = null!;
}
