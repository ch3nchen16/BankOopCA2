using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BankOopCA2.UserBank;
using DAL;

namespace BankOopCA2
{
    /// <summary>
    /// Interaction logic for UserAccount.xaml
    /// </summary>
    public partial class UserAccount : Window
    {
        public UserAccount()
        {
            InitializeComponent();
        }
        public string Fullname { get; set; }
        //private void LogOut_Click(object sender, RoutedEventArgs e)
        //{
        //    // Handle Log Out
        //    UserAccount. = false;
        //    dgv.ItemsSource = null; // Clear the grid when logging out
        //}
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            // Handle Exit
            Close();
        }
        private void NewAccount_Click(object sender, RoutedEventArgs e)
        {
            // Handle New Account
            AddAccount ac = new AddAccount();
            ac.Show();
        }

        private void EditAccount_Click(object sender, RoutedEventArgs e)
        {
            // Handle Edit Account
        }

        private void DepositFunds_Click(object sender, RoutedEventArgs e)
        {
            // Handle Deposit Funds
            
            //this.AddChild(ud);
        }

        private void WithdrawFunds_Click(object sender, RoutedEventArgs e)
        {
            // Handle Withdraw Funds
            UserCredit uc = new UserCredit();
        }

        private void TransferFunds_Click(object sender, RoutedEventArgs e)
        {
            // Handle Transfer Funds
        }

        private void ViewTransactions_Click(object sender, RoutedEventArgs e)
        {
            // Handle View Transactions
        }

        private void dgv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayAll dall = new DisplayAll();
            //dgv.ItemsSource = dall.AllAcc().DefaultView;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }


}

