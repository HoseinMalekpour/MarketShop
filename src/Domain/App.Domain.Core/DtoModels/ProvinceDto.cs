using System;
using System.Collections.Generic;

namespace App.Domain.Core.DtoModels;

public partial class ProvinceDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public virtual ICollection<CityDto> Cities { get; set; } = new List<CityDto>();
}
