using System;
using System.Windows.Forms;
using ATMApp.Data;
using ATMApp.Models;

namespace ATMApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void pinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            int customerId;
            int pin;
            if (int.TryParse(customerIdTextBox.Text, out customerId) && int.TryParse(pinTextBox.Text, out pin))
            {
                SqlHelper helper = new SqlHelper();
                Customer customer = helper.GetCustomer(customerId, pin);
                if (customer != null)
                {
                    this.Hide();
                    MainMenuForm mainMenu = new MainMenuForm(customer);
                    mainMenu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid login credentials.");
                }
            }
        }
    }
}