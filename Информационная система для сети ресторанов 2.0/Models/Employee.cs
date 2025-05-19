using System;
using System.Collections.Generic;

namespace Информационная_система_для_сети_ресторанов_2._0.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FullName { get; set; }

    public string? Position { get; set; }

    public int? Salary { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public int? RestaurantId { get; set; }

    public virtual Restaurant? Restaurant { get; set; }

    public virtual ICollection<RestaurantOrder> RestaurantOrders { get; set; } = new List<RestaurantOrder>();
}
