using System;
using System.Collections.Generic;

namespace App.Domain.Core.DtoModels;

public partial class StatusDto
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<OrderDto> Orders { get; set; } = new List<OrderDto>();
}
