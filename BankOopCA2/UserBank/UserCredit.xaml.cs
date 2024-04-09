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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankOopCA2.UserBank
{
    /// <summary>
    /// Interaction logic for UserCredit.xaml
    /// </summary>
    public partial class UserCredit : UserControl
    {
        DAO dao = new DAO();
        SqlDataReader dr;
        Bal ba = new Bal();
        public UserCredit()
        {
            InitializeComponent();
        }
        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            CloseWindow(sender, e);
        }

        private void btnCreditAccount_Click(object sender, RoutedEventArgs e)
        {
            decimal amt = decimal.Parse(txtTranAmount.Text);
            decimal bal = decimal.Parse(txtBal.Text);
            decimal nb = bal;

            if (amt < bal)
            {
                nb = bal + amt;
                MessageBox.Show("Sucess", "Alert", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Insufficient Funds", "Alert", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void txtBal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtBalFrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UserCredit_Loaded(object sender, LoadCompletedEventHandler e)
        {

        }

        private void UserCredit_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void txtBalFrom_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
