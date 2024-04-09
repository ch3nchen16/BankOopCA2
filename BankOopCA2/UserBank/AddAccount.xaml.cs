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
using BIZ;

namespace BankOopCA2
{
    /// <summary>
    /// Interaction logic for AddAccount.xaml
    /// </summary>
    public partial class AddAccount : Window
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void txtAddAcc_Click(object sender, RoutedEventArgs e)
        {
            string fn = txtFn.Text;
            string sn = txtSn.Text;
            string em = txtEm.Text;
            string ph = txtPh.Text;
            string ad1 = txtAd1.Text;
            string ad2 = txtAd2.Text;
            string county = cboCounty.SelectedItem.ToString();
            string city = txtCity.Text;
            string at = "Current Account";
            if (rdoSa.IsChecked == true)
                at = "Savings Account";
            int sort = 101010;
            decimal ib = decimal.Parse(txtDeposit.Text);
            int ol = 0;
            
            Account c = new Account(fn, sn, em, ph, ad1, ad2, county,city, at, sort, ib, ol);
        }
    }
}
