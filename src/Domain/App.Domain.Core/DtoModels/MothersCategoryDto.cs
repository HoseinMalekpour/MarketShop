using System;
using System.Collections.Generic;

namespace App.Domain.Core.DtoModels;

public partial class MothersCategoryDto
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public virtual ICollection<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
}
