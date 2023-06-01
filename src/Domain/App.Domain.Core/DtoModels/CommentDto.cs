using System;
using System.Collections.Generic;

namespace App.Domain.Core.DtoModels;
public partial class CommentDto
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string Comment1 { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public int BoothId { get; set; }

    public int OrderId { get; set; }

    public bool IsAccepted { get; set; }

    public virtual BoothDto Booth { get; set; } = null!;

    public virtual OrderDto Order { get; set; } = null!;

    public virtual AppUserDto User { get; set; } = null!;
}
