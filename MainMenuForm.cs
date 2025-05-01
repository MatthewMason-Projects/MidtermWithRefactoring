
using System;
using System.Windows.Forms;
using ATMApp.Models;
using ATMApp.Data;

namespace ATMApp.Forms
{
    public partial class MainMenuForm : Form
    {
        private Customer customer;
        private SqlHelper helper = new SqlHelper();

        public MainMenuForm(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }
        private void withdrawCheckingButton_Click(object sender, EventArgs e)
        {
            decimal amount = numericUpDown1.Value;
            try
            {
                customer.Checking.Withdraw(amount);
                helper.UpdateAccount(customer.Checking);
                helper.UpdateAccount(customer.Savings);
                MessageBox.Show("Withdrawal successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void withdrawSavingsButton_Click(object sender, EventArgs e)
        {
            decimal amount = numericUpDown2.Value; 
            try
            {
                
                customer.Savings.Withdraw(amount);
                helper.UpdateAccount(customer.Savings);  
                MessageBox.Show("Withdrawal successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void transferToSavingsButton_Click(object sender, EventArgs e)
        {
            decimal amount = numericUpDown3.Value;
            try
            {
                helper.TransferFunds(customer.Checking, customer.Savings, amount);
                MessageBox.Show("Transfer successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void transferToCheckingButton_Click(object sender, EventArgs e)
        {
            decimal amount = numericUpDown4.Value;
            try
            {
                helper.TransferFunds(customer.Savings, customer.Checking, amount);
                MessageBox.Show("Transfer successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }

        private void checkBalanceButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Checking: ${customer.Checking.Balance}\nSavings: ${customer.Savings.Balance}");
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
