using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace firstWpfapp
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Window
    {
        private ConnectionString _cs = new ConnectionString();
        public RegisterPage()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            
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

            //Thread which displays error messages if txt fields are faulty.
            Dispatcher.Invoke(new Action(() => { values(); }), DispatcherPriority.ContextIdle);

            if (firstName.Length < 2 || lastName.Length < 2 ||
                   company.Length < 2 || position.Length < 2 ||
                  username.Length < 4 ||
                  password.Length < 6 ||
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
                _cs.regUser(user);
                MessageBox.Show("Successfully registered!");
                this.Close();
            }
            

        }

        private void values()
        {

            List<String> ErrorMessages = new List<String>();
            //first name
            if (txtDisplayFirstName.Text.Length <= 2)
            {
                ErrorMessages.Add("Please ensure your first name is correct!");
                txtDisplayFirstName.Foreground = Brushes.Red;
                txtDisplayFirstName.Text = ErrorMessages[0].ToString();
            }
            //last name
            if (txtDisplayLastName.Text.Length <= 2)
            {
                ErrorMessages.Add("Please make sure your last name is correct!");
                txtDisplayLastName.Foreground = Brushes.Red;
                txtDisplayLastName.Text = ErrorMessages[1].ToString();
            }
            //company name
            if (txtCompanyName.Text.Length <= 2)
            {
                ErrorMessages.Add("Please ensure that the company name is correct!");
                txtCompanyName.Foreground = Brushes.Red;
                txtCompanyName.Text = ErrorMessages[2].ToString();
            }
            //position title
            if (txtPosition.Text.Length <= 2)
            {
                ErrorMessages.Add("Ensure that your position title is correct!");
                txtPosition.Foreground = Brushes.Red;
                txtPosition.Text = ErrorMessages[3].ToString();
            }
            //username
            if (txtName.Text.Length < 4)
            {
                ErrorMessages.Add("Please ensure your username is at least 4 symbols!");
                txtName.Foreground = Brushes.Red;
                txtName.Text = ErrorMessages[4].ToString();
            }
            //password
            if (txtPassword.Password.Length < 6)
            {
                txtPassword.Password = " ";
                txtPassword.Foreground = Brushes.Red;
                MessageBox.Show("Please ensure your password is at least 6 symbols!");
            }
            //confirm password
            if (!txtConfirmPassword.Password.Equals(txtPassword.Password))
            {
                txtConfirmPassword.Password = " ";
                txtConfirmPassword.Foreground = Brushes.Red;
                MessageBox.Show("Please ensure your password fields are identical!");
            }
        }
    }
}
