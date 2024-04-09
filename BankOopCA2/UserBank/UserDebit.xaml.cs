using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BIZ;

namespace BankOopCA2.UserBank
{
    /// <summary>
    /// Interaction logic for UserDebit.xaml
    /// </summary>
    public partial class UserDebit : UserControl
    {
        DAO dao = new DAO();
        SqlDataReader dr;
        Bal ba = new Bal();
        public UserDebit()
        {
            InitializeComponent();
        }

        private void btnDebitAccount_Click(object sender, RoutedEventArgs e)
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
        private void CloseWindow(object sender, RoutedEventArgs e)
        {
        }

        private void txtBal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UserDebit_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void txtBalFrom_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
