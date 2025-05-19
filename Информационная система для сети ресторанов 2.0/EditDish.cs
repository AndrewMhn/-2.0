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
    public partial class EditDish : Form
    {
        public EditDish()
        {
            InitializeComponent();
        }

        private void btnSaveEditDish_Click(object sender, EventArgs e)
        {
        //    if (int.TryParse(txtEditDishPrice.Text, out int price) &&
        //        int.TryParse(txtEditDishPrice.Text, out int cost))
        //    {
        //        using (var context = new RestaurantChainContext())
        //        {
        //            Menu dish = null;

        //            foreach (var d in context.Menus)
        //            {
        //                if (d.DishName == dishName)
        //                {
        //                    dish = d;
        //                    break;
        //                }
        //            }
        //            if (dish != null)
        //            {
        //                dish.DishName = txtEditDishTitle.Text;
        //                dish.DishPrice = price;
        //                dish.DishCost = cost;
        //                dish.RestaurantId = (int)cmbEditDishRestaurant.SelectedValue;

        //                context.SaveChanges();
        //                this.DialogResult = DialogResult.OK;
        //                this.Close();
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Неверные значения цены или себестоимости.");
        //    }
        }
    }
}
