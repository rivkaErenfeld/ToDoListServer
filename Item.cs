using System;
using System.Collections.Generic;

namespace TodoApi2;

public partial class Item
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty; 

    public bool? IsComplete { get; set; }
}
