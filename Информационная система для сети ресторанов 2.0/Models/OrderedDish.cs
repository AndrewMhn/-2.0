using System;
using System.Collections.Generic;

namespace Информационная_система_для_сети_ресторанов_2._0.Models;

public partial class OrderedDish
{
    public int OrderedDishId { get; set; }

    public int? OrderId { get; set; }

    public int? DishId { get; set; }

    public int? Quantity { get; set; }

    public virtual Menu? Dish { get; set; }

    public virtual RestaurantOrder? Order { get; set; }
}
