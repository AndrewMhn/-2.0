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
    public partial class AddEmpoyee : Form
    {
        public AddEmpoyee()
        {
            InitializeComponent();
            using (var context = new RestaurantChainContext())
            {
                var restaurants = context.Restaurants.ToList();
                cmbEmployeeRestaurant.DataSource = restaurants;
                cmbEmployeeRestaurant.DisplayMember = "Name";
                cmbEmployeeRestaurant.ValueMember = "RestaurantId";
            }
        }

        private void AddEmpoyee_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (var context = new RestaurantChainContext())
            {
                var employee = new Employee
                {
                    FullName = txtEmployeeName.Text,
                    Position = txtEmployeePosition.Text,
                    Salary = int.Parse(txtEmployeeSalary.Text),
                    PhoneNumber = txtEmployeeNumber.Text,
                    Username = txtEmployeeLogin.Text,
                    Password = txtEmployeePassword.Text,
                    RestaurantId = (int)cmbEmployeeRestaurant.SelectedValue
                };

                context.Employees.Add(employee);
                context.SaveChanges();

                MessageBox.Show("Сотрудник добавлен!");
                this.Close();
            }
        }
    }
}
