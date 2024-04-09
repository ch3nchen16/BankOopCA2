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
using System.Windows.Shapes;
using BIZ;

namespace BankOopCA2.UserBank
{
    /// <summary>
    /// Interaction logic for Transfer.xaml
    /// </summary>
    public partial class Transfer : Window
    {
        public Transfer()
        {
            InitializeComponent();
        }
        DAO dao = new DAO();
        SqlDataReader dr;
        Bal ba = new Bal();

        private void btnDebitAccount_Click(object sender, RoutedEventArgs e)
        {
            decimal amt = decimal.Parse(txtTranAmmount.Text);
            decimal bal = decimal.Parse(txtBalFrom.Text);
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
        void PopCombo()
        {
            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspPopCombo";
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string acc = dr["AccNum"].ToString();
                comboSecondAccount.Items.Add(acc);
            }
            dao.CloseCon();
        }
        private void TransferFund_Loaded(object sender, RoutedEventArgs e)
        {
            GetAllAccount();
            PopCombo();
        }
        private void GetAllAccount()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ap = new SqlDataAdapter();
            ap.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                comboSecondAccount.ItemsSource = dt.DefaultView;
                comboSecondAccount.DisplayMemberPath = dt.Columns["AccNum"].ToString();
                comboSecondAccount.SelectedValuePath = dt.Columns["AccNum"].ToString();
            }
        }

        private void NewAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DepositFunds_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WithdrawFunds_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TransferFunds_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ViewTransactions_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtBalFrom_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
    
}
