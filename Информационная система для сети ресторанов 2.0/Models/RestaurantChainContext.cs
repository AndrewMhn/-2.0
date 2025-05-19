using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Информационная_система_для_сети_ресторанов_2._0.Models;

public partial class RestaurantChainContext : DbContext
{
    public RestaurantChainContext()
    {
    }

    public RestaurantChainContext(DbContextOptions<RestaurantChainContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<OrderedDish> OrderedDishes { get; set; }

    public virtual DbSet<OtherExpense> OtherExpenses { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    public virtual DbSet<RestaurantOrder> RestaurantOrders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=admin123;password=admin123_password;database=restaurant_chain", Microsoft.EntityFrameworkCore.ServerVersion.Parse("9.1.0-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Delivery>(entity =>
        {
            entity.HasKey(e => e.DeliveryId).HasName("PRIMARY");

            entity.ToTable("delivery");

            entity.HasIndex(e => e.ProviderId, "provider_id");

            entity.HasIndex(e => e.RestaurantId, "restaurant_id");

            entity.Property(e => e.DeliveryId).HasColumnName("delivery_id");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("delivery_date");
            entity.Property(e => e.ProviderId).HasColumnName("provider_id");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");
            entity.Property(e => e.TotalCost).HasColumnName("total_cost");

            entity.HasOne(d => d.Provider).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.ProviderId)
                .HasConstraintName("delivery_ibfk_2");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.RestaurantId)
                .HasConstraintName("delivery_ibfk_1");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PRIMARY");

            entity.ToTable("employee");

            entity.HasIndex(e => e.RestaurantId, "restaurant_id");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .HasColumnName("full_name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .HasColumnName("phone_number");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasColumnName("position");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");
            entity.Property(e => e.Salary).HasColumnName("salary");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.Employees)
                .HasForeignKey(d => d.RestaurantId)
                .HasConstraintName("employee_ibfk_1");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.DishId).HasName("PRIMARY");

            entity.ToTable("menu");

            entity.HasIndex(e => e.RestaurantId, "restaurant_id");

            entity.Property(e => e.DishId).HasColumnName("dish_id");
            entity.Property(e => e.DishCost).HasColumnName("dish_cost");
            entity.Property(e => e.DishName)
                .HasMaxLength(50)
                .HasColumnName("dish_name");
            entity.Property(e => e.DishPrice).HasColumnName("dish_price");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.Menus)
                .HasForeignKey(d => d.RestaurantId)
                .HasConstraintName("menu_ibfk_1");
        });

        modelBuilder.Entity<OrderedDish>(entity =>
        {
            entity.HasKey(e => e.OrderedDishId).HasName("PRIMARY");

            entity.ToTable("ordered_dish");

            entity.HasIndex(e => e.DishId, "dish_id");

            entity.HasIndex(e => e.OrderId, "order_id");

            entity.Property(e => e.OrderedDishId).HasColumnName("ordered_dish_id");
            entity.Property(e => e.DishId).HasColumnName("dish_id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Dish).WithMany(p => p.OrderedDishes)
                .HasForeignKey(d => d.DishId)
                .HasConstraintName("ordered_dish_ibfk_2");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderedDishes)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("ordered_dish_ibfk_1");
        });

        modelBuilder.Entity<OtherExpense>(entity =>
        {
            entity.HasKey(e => e.ExpenseId).HasName("PRIMARY");

            entity.ToTable("other_expenses");

            entity.HasIndex(e => e.RestaurantId, "restaurant_id");

            entity.Property(e => e.ExpenseId).HasColumnName("expense_id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.ExpenseDate)
                .HasColumnType("datetime")
                .HasColumnName("expense_date");
            entity.Property(e => e.ExpenseType)
                .HasMaxLength(50)
                .HasColumnName("expense_type");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.OtherExpenses)
                .HasForeignKey(d => d.RestaurantId)
                .HasConstraintName("other_expenses_ibfk_1");
        });

        modelBuilder.Entity<Provider>(entity =>
        {
            entity.HasKey(e => e.ProviderId).HasName("PRIMARY");

            entity.ToTable("provider");

            entity.Property(e => e.ProviderId).HasColumnName("provider_id");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(50)
                .HasColumnName("contact_person");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .HasColumnName("phone_number");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity.HasKey(e => e.RestaurantId).HasName("PRIMARY");

            entity.ToTable("restaurant");

            entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<RestaurantOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PRIMARY");

            entity.ToTable("restaurant_order");

            entity.HasIndex(e => e.EmployeeId, "employee_id");

            entity.HasIndex(e => e.RestaurantId, "restaurant_id");

            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("order_date");
            entity.Property(e => e.RestaurantId).HasColumnName("restaurant_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.RestaurantOrders)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("restaurant_order_ibfk_2");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.RestaurantOrders)
                .HasForeignKey(d => d.RestaurantId)
                .HasConstraintName("restaurant_order_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
