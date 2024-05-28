using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string Name { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string HomeAddress { get; set; } = null!;

    public string? SubAddresses { get; set; }

    public virtual ICollection<Cart> Carts { get; } = new List<Cart>();

    public virtual ICollection<CustomerInteraction> CustomerInteractions { get; } = new List<CustomerInteraction>();

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
