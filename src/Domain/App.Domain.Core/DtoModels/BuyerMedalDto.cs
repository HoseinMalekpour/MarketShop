using System;
using System.Collections.Generic;


namespace App.Domain.Core.DtoModels;

public partial class BuyerMedalDto
{
    public int Id { get; set; }

    public int DiscountPercent { get; set; }

    public int CountOfBuy { get; set; }

    public virtual ICollection<AppUserDto> AppUsers { get; set; } = new List<AppUserDto>();
}
