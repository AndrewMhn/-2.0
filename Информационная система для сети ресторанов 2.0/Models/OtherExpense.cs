using System;
using System.Collections.Generic;

namespace Информационная_система_для_сети_ресторанов_2._0.Models;

public partial class OtherExpense
{
    public int ExpenseId { get; set; }

    public string? ExpenseType { get; set; }

    public int? Amount { get; set; }

    public DateTime? ExpenseDate { get; set; }

    public int? RestaurantId { get; set; }

    public virtual Restaurant? Restaurant { get; set; }
}
