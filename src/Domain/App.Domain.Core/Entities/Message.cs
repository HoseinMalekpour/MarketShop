using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class Message
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Text { get; set; } = null!;

    public bool IsRead { get; set; }

    public DateTime CreateAt { get; set; }

    public int CreateBy { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<MessagesUser> MessagesUsers { get; set; } = new List<MessagesUser>();
}
