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
using System.Windows.Shapes;
using BIZ;

namespace BankOopCA2
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        Biz b = new Biz();
        
        
        public Register()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            Close();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            textBoxFullname.Text = "";
            textBoxUsername.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
            passwordBox1.Password = "";
            passwordBoxConfirm.Password = "";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                errormessage.Text = "Enter an email.";
                textBoxEmail.Focus();
            }
            else if (!Regex.IsMatch(textBoxEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                textBoxEmail.Select(0, textBoxEmail.Text.Length);
                textBoxEmail.Focus();
            }
            if (passwordBox1.Password.Length == 0)
            {
                errormessage.Text = "Enter password.";
                passwordBox1.Focus();
            }
            else if (passwordBoxConfirm.Password.Length == 0)
            {
                errormessage.Text = "Enter Confirm password.";
                passwordBoxConfirm.Focus();
            }
            else if (passwordBox1.Password != passwordBoxConfirm.Password)
            {
                errormessage.Text = "Confirm password must be same as password.";
                passwordBoxConfirm.Focus();
            }
            else
            {
                string fn = textBoxFullname.Text;
                string un = textBoxUsername.Text;
                string email = textBoxEmail.Text;
                string pw = passwordBox1.Password;
                string ad = textBoxAddress.Text;

                b.RegUser(fn, un, pw, email, ad);
                errormessage.Text = "You have Registered successfully.";
                Reset();
            }

        }
    }
}
    

