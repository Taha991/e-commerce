using System;
using System.Collections.Generic;

namespace MemoApi.Data.Models;

public partial class UserAuth
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string HashedPassword { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? LastLogin { get; set; }

    public string? IsActive { get; set; }

    public virtual ICollection<CustomerInteraction> CustomerInteractions { get; } = new List<CustomerInteraction>();

    public virtual ICollection<Role> Roles { get; } = new List<Role>();
}
