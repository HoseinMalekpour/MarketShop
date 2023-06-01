using System;
using System.Collections.Generic;


namespace App.Domain.Core.DtoModels;

public partial class ImageDto
{
    public int Id { get; set; }

    public string Path { get; set; } = null!;

    public bool Isdeleted { get; set; }

    public bool IsProfileImage { get; set; }

    public bool IsAccepted { get; set; }

    public virtual ICollection<AppUserDto> AspNetUsers { get; set; } = new List<AppUserDto>();

    public virtual ICollection<BoothDto> Booths { get; set; } = new List<BoothDto>();

    public virtual ICollection<ProductImageDto> ProductImages { get; set; } = new List<ProductImageDto>();
}
