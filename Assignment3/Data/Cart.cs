﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3.Data;

public partial class Cart
{
    public int Id { get; set; }

    
    public int ProductIds { get; set; }

    public string? Quantities { get; set; }

   
    public int? UserId { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual Product ProductIdsNavigation { get; set; } = null!;

    public virtual User? User { get; set; }
}
