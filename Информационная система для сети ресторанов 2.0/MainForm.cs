using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Информационная_система_для_сети_ресторанов_2._0.Models;
using Информационная_система_для_сети_ресторанов_2._0;

namespace Информационная_система_для_сети_ресторанов
{
    public partial class MainForm : Form
    {
        private string currentTable = "";

        bool isEdit = false;

        private readonly RestaurantChainContext context;
        public MainForm()
        {
            InitializeComponent();
            context = new RestaurantChainContext();
        }

        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            currentTable = "deliveries";

            LoadDeliveries();
            dataGridView.Columns[0].HeaderText = "Дата поставки";
            dataGridView.Columns[1].HeaderText = "Стоимость";
            dataGridView.Columns[2].HeaderText = "Ресторан";
            dataGridView.Columns[3].HeaderText = "Поставщик";
        }
        private void LoadDeliveries()
        {
            using (var context = new RestaurantChainContext())
            {
                var deliveries = context.Deliveries
                    .Select(d => new
                    {
                        d.DeliveryDate,
                        d.TotalCost,
                        RestaurantName = context.Restaurants
                            .Where(r => r.RestaurantId == d.RestaurantId)
                            .Select(r => r.Name)
                            .FirstOrDefault(),
                        ProviderName = context.Providers
                            .Where(p => p.ProviderId == d.ProviderId)
                            .Select(p => p.Title)
                            .FirstOrDefault()
                    })
                    .ToList();

                dataGridView.DataSource = deliveries;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentTable = "expenses";

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            currentTable = "menu";
            LoadMenu();
            dataGridView.Columns[0].HeaderText = "Название";
            dataGridView.Columns[1].HeaderText = "Цена";
            dataGridView.Columns[2].HeaderText = "Себестоимость";
            dataGridView.Columns[3].HeaderText = "Ресторан";
        }

        private void LoadMenu()
        {
            using (var context = new RestaurantChainContext())
            {
                var menuItems = (from m in context.Menus
                                 join r in context.Restaurants on m.RestaurantId equals r.RestaurantId
                                 select new
                                 {                                   
                                     m.DishName,
                                     m.DishPrice,
                                     m.DishCost,
                                     RestaurantName = r.Name,
                                     m.DishId
                                 }).ToList();

                dataGridView.DataSource = menuItems;

                dataGridView.Columns["DishId"].Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurants_Click(object sender, EventArgs e)
        {
            currentTable = "restaurants";
            LoadRestaurants();

        }
        private void LoadRestaurants()
        {
            using (var context = new RestaurantChainContext())
            {
                var list = new List<object>();

                foreach (var r in context.Restaurants)
                {
                    list.Add(new
                    {
                        Название = r.Name,
                        Адрес = r.Address
                    });
                }

                dataGridView.DataSource = list;
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            currentTable = "employee";
            LoadEmployees();
            dataGridView.Columns[0].HeaderText = "Полное имя";
            dataGridView.Columns[1].HeaderText = "Должность";
            dataGridView.Columns[2].HeaderText = "Зарплата";
            dataGridView.Columns[3].HeaderText = "Номер телефона";
            dataGridView.Columns[4].HeaderText = "Логин";
            dataGridView.Columns[5].HeaderText = "Пароль";
            dataGridView.Columns[6].HeaderText = "Ресторан";
        }
        private void LoadEmployees()
        {
            using (var context = new RestaurantChainContext())
            {
                var employees = (from e in context.Employees
                                 join r in context.Restaurants on e.RestaurantId equals r.RestaurantId
                                 select new
                                 {
                                     e.FullName,
                                     e.Position,
                                     e.Salary,
                                     e.PhoneNumber,
                                     e.Username,
                                     e.Password,
                                     RestaurantName = r.Name
                                 }).ToList();

                dataGridView.DataSource = employees;
            }
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            currentTable = "finance";

        }

        private void btnProviders_Click(object sender, EventArgs e)
        {
            currentTable = "providers";

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            currentTable = "orders";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (currentTable)
            {
                case "restaurants":
                    var addRestaurantForm = new AddRestaurant();
                    addRestaurantForm.ShowDialog();
                    LoadRestaurants();
                    break;

                case "deliveries":
                    var addDeliveryForm = new AddDelivery();
                    addDeliveryForm.ShowDialog();
                    LoadDeliveries();
                    break;

                case "menu":
                    var addDishForm = new AddDish();
                    addDishForm.ShowDialog();
                    LoadMenu();
                    break;

                case "providers":
                    var addProviderForm = new AddProvider();
                    addProviderForm.ShowDialog();
                    LoadDeliveries();
                    break;

                case "orders":
                    var AddOrderForm = new AddOrder();
                    AddOrderForm.ShowDialog();
                    LoadDeliveries();
                    break;

                case "employee":
                    var AddEmpoyeeFrom = new AddEmpoyee();
                    AddEmpoyeeFrom.ShowDialog();
                    LoadDeliveries();
                    break;

                case "expense":
                    var AddExpenseForm = new AddExpense();
                    AddExpenseForm.ShowDialog();
                    LoadDeliveries();
                    break;

                    //default:
                    //    MessageBox.Show("Сначала выберите раздел.");
                    //    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            switch (currentTable)
            {
                case "menu":
                    {
                        if (!isEdit)
                        {
                            // Включаем редактирование
                            dataGridView.ReadOnly = false;

                            // Блокируем редактирование столбца с названием ресторана
                            if (dataGridView.Columns.Contains("RestaurantName"))
                            {
                                dataGridView.Columns["RestaurantName"].ReadOnly = true;
                            }

                            btnEdit.Text = "Сохранить";
                            isEdit = true;
                        }
                        else
                        {
                            // Сохраняем изменения
                            using (var context = new RestaurantChainContext())
                            {
                                foreach (DataGridViewRow row in dataGridView.Rows)
                                {
                                    if (row.IsNewRow) continue;

                                    // Получаем ID блюда
                                    if (row.Cells["DishId"].Value == null) continue;
                                    int dishId = Convert.ToInt32(row.Cells["DishId"].Value);

                                    var dish = context.Menus.FirstOrDefault(d => d.DishId == dishId);
                                    if (dish != null)
                                    {
                                        dish.DishName = row.Cells["DishName"].Value?.ToString();

                                        if (int.TryParse(row.Cells["DishPrice"].Value?.ToString(), out int price))
                                            dish.DishPrice = price;

                                        if (int.TryParse(row.Cells["DishCost"].Value?.ToString(), out int cost))
                                            dish.DishCost = cost;

                                    }
                                }

                                context.SaveChanges();
                            }

                            dataGridView.ReadOnly = true;
                            btnEdit.Text = "Редактировать";
                            isEdit = false;
                        }
                    }
                    break;
                
            }
        }
    }
}

