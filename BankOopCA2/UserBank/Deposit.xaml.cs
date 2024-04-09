﻿using BIZ;
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
    /// Interaction logic for Deposit.xaml
    /// </summary>
    public partial class Deposit : Window
    {
        public Deposit()
        {
            InitializeComponent();
        }
        DAO dao = new DAO();
        SqlDataReader dr;
        Bal ba = new Bal();

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
    }
}
