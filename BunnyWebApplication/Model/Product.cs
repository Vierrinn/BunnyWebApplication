using System;
using System.Collections.Generic;

namespace BunnyWebApplication.Model;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; } 

    public int Cost { get; set; }

    public string? Size { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; } 

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
