using System;
using System.Collections.Generic;

namespace Информационная_система_для_сети_ресторанов_2._0.Models;

public partial class RestaurantOrder
{
    public int OrderId { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? RestaurantId { get; set; }

    public int? EmployeeId { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<OrderedDish> OrderedDishes { get; set; } = new List<OrderedDish>();

    public virtual Restaurant? Restaurant { get; set; }
}
