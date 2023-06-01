using System;
using System.Collections.Generic;


namespace App.Domain.Core.DtoModels;

public partial class OrderDto
{
    public int Id { get; set; }

    public string BuyerUserId { get; set; } = null!;

    public DateTime OrderCreatTime { get; set; }

    public int StatusId { get; set; }

    public bool IsDeleted { get; set; }

    public int BoothId { get; set; }

    public int TotalPrice { get; set; }

    public virtual BoothDto Booth { get; set; } = null!;

    public virtual AppUserDto BuyerUser { get; set; } = null!;

    public virtual ICollection<CommentDto> Comments { get; set; } = new List<CommentDto>();

    public virtual ICollection<OrderProductDto> OrderProducts { get; set; } = new List<OrderProductDto>();

    public virtual StatusDto Status { get; set; } = null!;
}
