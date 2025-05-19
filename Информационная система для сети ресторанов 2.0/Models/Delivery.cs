using System;
using System.Collections.Generic;

namespace Информационная_система_для_сети_ресторанов_2._0.Models;

public partial class Delivery
{
    public int DeliveryId { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public int? TotalCost { get; set; }

    public int? RestaurantId { get; set; }

    public int? ProviderId { get; set; }

    public virtual Provider? Provider { get; set; }

    public virtual Restaurant? Restaurant { get; set; }
}
