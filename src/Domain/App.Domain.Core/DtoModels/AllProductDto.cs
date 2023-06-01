using System;
using System.Collections.Generic;

namespace App.Domain.Core.DtoModels;
public partial class AllProductDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CategoryId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsCreated { get; set; }

    public virtual CategoryDto Category { get; set; } = null!;

    public virtual ICollection<ProductDto> Products { get; set; } = new List<ProductDto>();
}
