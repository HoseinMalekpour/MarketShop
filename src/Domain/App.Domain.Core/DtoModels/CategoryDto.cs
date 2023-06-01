using System;
using System.Collections.Generic;

namespace App.Domain.Core.DtoModels;

public partial class CategoryDto
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int MotherCategoryId { get; set; }

    public virtual ICollection<AllProductDto> AllProducts { get; set; } = new List<AllProductDto>();

    public virtual MothersCategoryDto MotherCategory { get; set; } = null!;
}
