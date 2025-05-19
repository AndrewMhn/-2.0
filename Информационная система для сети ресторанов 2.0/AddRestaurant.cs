using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Информационная_система_для_сети_ресторанов_2._0.Models;

namespace Информационная_система_для_сети_ресторанов_2._0
{
    public partial class AddRestaurant : Form
    {
        public AddRestaurant()
        {
            InitializeComponent();
        }

        private void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            string title = txtRestaurantTitle.Text.Trim();
            string address = txtRestaurantAddress.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            using (var context = new RestaurantChainContext())
            {
                var restaurant = new Restaurant
                {
                    Name = title,
                    Address = address
                };

                context.Restaurants.Add(restaurant);
                context.SaveChanges();
            }

            MessageBox.Show("Ресторан успешно добавлен.");
            this.Close();
        }
    }
}
