using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class MessagesUser
{
    public int Id { get; set; }

    public int MessageId { get; set; }

    public int UserId { get; set; } 

    public virtual Message Message { get; set; } = null!;

    public virtual AppUser User { get; set; } = null!;
}
