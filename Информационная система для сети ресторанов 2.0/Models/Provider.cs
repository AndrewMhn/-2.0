using System;
using System.Collections.Generic;

namespace Информационная_система_для_сети_ресторанов_2._0.Models;

public partial class Provider
{
    public int ProviderId { get; set; }

    public string? Title { get; set; }

    public string? ContactPerson { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();
}
