using System;
using System.Collections.Generic;

namespace App.Domain.Core.DtoModels;

public partial class OrderProductDto
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public virtual OrderDto Order { get; set; } = null!;

    public virtual ProductDto Product { get; set; } = null!;
}
