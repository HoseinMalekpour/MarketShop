using System;
using System.Collections.Generic;

namespace App.Domain.Core.DtoModels;

public partial class MessageDto
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Text { get; set; } = null!;

    public bool IsRead { get; set; }

    public DateTime CreateAt { get; set; }

    public string CreateBy { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public virtual ICollection<MessagesUserDto> MessagesUsers { get; set; } = new List<MessagesUserDto>();
}
