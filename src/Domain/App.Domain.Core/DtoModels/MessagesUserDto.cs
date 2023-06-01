using System;
using System.Collections.Generic;
using App.Domain.Core.DtoModels;

namespace App.Domain.Core.DtoModels;

public partial class MessagesUserDto
{
    public int Id { get; set; }

    public int MessageId { get; set; }

    public string UserId { get; set; } = null!;

    public virtual MessageDto Message { get; set; } = null!;

    public virtual AppUserDto User { get; set; } = null!;
}
