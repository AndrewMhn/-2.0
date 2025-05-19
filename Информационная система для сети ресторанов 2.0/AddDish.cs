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


namespace Информационная_система_для_сети_ресторанов_2._0
{
    public partial class AddDish : Form
    {
        public AddDish()
        {
            InitializeComponent();
        }

        private void AddDish_Load(object sender, EventArgs e)
        {
            using (var context = new RestaurantChainContext())
            {
                var restaurants = context.Restaurants.ToList();
                cmbDishRestaurant.DataSource = restaurants;
                cmbDishRestaurant.DisplayMember = "Name";
                cmbDishRestaurant.ValueMember = "RestaurantId";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            string dishName = txtDishName.Text.Trim();
            int price, cost;

            if (string.IsNullOrEmpty(dishName) ||
                !int.TryParse(txtDishPrice.Text, out price) ||
                !int.TryParse(txtDishCost.Text, out cost) ||
                cmbDishRestaurant.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, заполните корректно все поля.");
                return;
            }

            int restaurantId = (int)cmbDishRestaurant.SelectedValue;

            using (var context = new RestaurantChainContext())
            {
                var dish = new Menu
                {
                    DishName = dishName,
                    DishPrice = price,
                    DishCost = cost,
                    RestaurantId = restaurantId
                };

                context.Menus.Add(dish);
                context.SaveChanges();
            }

            MessageBox.Show("Блюдо добавлено.");
            this.Close();
        }

        private void txtDishName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
