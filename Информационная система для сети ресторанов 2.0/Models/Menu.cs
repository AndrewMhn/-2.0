using System;
using System.Collections.Generic;

namespace Информационная_система_для_сети_ресторанов_2._0.Models;

public partial class Menu
{
    public int DishId { get; set; }

    public string? DishName { get; set; }

    public int? DishPrice { get; set; }

    public int? DishCost { get; set; }

    public int? RestaurantId { get; set; }

    public virtual ICollection<OrderedDish> OrderedDishes { get; set; } = new List<OrderedDish>();

    public virtual Restaurant? Restaurant { get; set; }
}
