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

namespace firstWpfapp
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Window
    {
        private ConnectionString cs = new ConnectionString();
        public RegisterPage()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            cs.getUsers();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSupport_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Just so you know that: \n" +
                "First name \n" +
                "Last name \n" +
                "Company \n" +
                "Position \n" +
                "-- Must be longer than 2 characters! \n" +
                " - Username must be longer than 4 characters - \n" +
                " - Password must be longer than 6 characters - \n" +
                " - Confirm password must be the same as password - \n" +
                "Please make sure everything is correct in order to be registered! ");

        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            String firstName = txtDisplayFirstName.Text;
            String lastName = txtDisplayLastName.Text;
            String company = txtCompanyName.Text;
            String position = txtPosition.Text;
            String username = txtName.Text;
            String password = txtPassword.Password;
            String confirmPassword = txtConfirmPassword.Password;
            DateTime regDate = DateTime.Now;

            Users user = new Users();
            
            if(  firstName.Length<2||lastName.Length<2||
                   company.Length<2||position.Length<2||
                  username.Length<4||
                  password.Length<6||
                 !confirmPassword.Equals(password))
            {
                MessageBox.Show("Please verify the fields or click the support button next to Registration!");
            }
            else
            {
                user.setFirstName(firstName);
                user.setLastName(lastName);
                user.setUsername(username);
                user.setPassword(password);
                user.setCompany(company);
                user.setPosition(position);
                user.setRegDate(regDate);
                cs.regUser(user);
                MessageBox.Show("Successfully registered!");
                this.Close();
            }

        }
    }
}
