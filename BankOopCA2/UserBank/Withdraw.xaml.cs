using BIZ;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace BankOopCA2.UserBank
{
    /// <summary>
    /// Interaction logic for Withdrawl.xaml
    /// </summary>
    public partial class Withdrawl : Window
    {
        public Withdrawl()
        {
            InitializeComponent();
        }
        DAO dao = new DAO();
        SqlDataReader dr;
        Bal ba = new Bal();

        private void WithdrawFunds_Click(object sender, RoutedEventArgs e)
        {
            decimal amt = decimal.Parse(txtTranAmount.Text);
            decimal bal = decimal.Parse(txtBal.Text);
            decimal nb = bal;

            if (amt < bal)
            {
                nb = bal - amt;
                MessageBox.Show("Sucess", "Alert", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Insufficient Funds", "Alert", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ViewTransactions_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtBalFrom_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDebitAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DepositFunds_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TransferFunds_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
