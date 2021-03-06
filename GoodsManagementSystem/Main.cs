using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoodsBox_Click(object sender, EventArgs e)
        {
            ManageProducts prod = new ManageProducts();
            prod.Show();
            this.Hide();
        }

        private void UsersBox_Click(object sender, EventArgs e)
        {
            ManageUsers user = new ManageUsers();
            user.Show();
            this.Hide();
        }

        private void CategoryBox_Click(object sender, EventArgs e)
        {
            ManageCategories cate = new ManageCategories();
            cate.Show();
            this.Hide();
        }

        private void CustomersBox_Click(object sender, EventArgs e)
        {
            ManageCustomers custo = new ManageCustomers();
            custo.Show();
            this.Hide();
        }

        private void OrdersBox_Click(object sender, EventArgs e)
        {
            ManageOrders custo = new ManageOrders();
            custo.Show();
            this.Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

    }
}
