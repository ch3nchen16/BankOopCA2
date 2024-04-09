using DAL;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace BankOopCA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        UserAccount ua = new UserAccount();
        Login l = new Login();
        //Register register = new Register();
        DAO dao = new DAO();
        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            string user = txtUser.Text;
            string pass = Pwbox.Password;
            ua.Fullname = l.GetUser(user, pass);
            if (ua.Fullname == "Error")
            {
                MessageBox.Show("Nobody in database");
            }
            else if (txtUser.Text.Length == 0)
            {
                errormessage.Text = "Enter an email.";
                txtUser.Focus();
            }
            else if (!Regex.IsMatch(txtUser.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                txtUser.Select(0, txtUser.Text.Length);
                txtUser.Focus();
            }
            txtUser.Clear();
            Pwbox.Clear();
            ua.Show();
            Close();
        }

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            //register.Show();
            //Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
