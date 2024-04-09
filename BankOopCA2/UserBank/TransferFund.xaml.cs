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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DAL;
using BIZ;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace BankOopCA2
{
    /// <summary>
    /// Interaction logic for TransferFund.xaml
    /// </summary>
    public partial class TransferFund : UserControl
    {
        DAO dao = new DAO();
        SqlDataReader dr;
        Bal ba = new Bal();
        public TransferFund()
        {
            InitializeComponent();
        }
        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            CloseWindow(sender, e);
        }
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
        private void txtBalTo_SelectionChanged(object sender, RoutedEventArgs e)
        {
            //ba.GetBalTo(int AccNum, string );
        }

        private void txtBalFrom_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void txtBalFrom_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
