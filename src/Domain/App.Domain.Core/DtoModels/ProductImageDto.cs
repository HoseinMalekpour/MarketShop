using System;
using System.Collections.Generic;

namespace App.Domain.Core.DtoModels;

public partial class ProductImageDto
{
    public int Id { get; set; }

    public int ImageId { get; set; }

    public int ProductId { get; set; }

    public virtual ImageDto Image { get; set; } = null!;

    public virtual ProductDto Product { get; set; } = null!;
}
