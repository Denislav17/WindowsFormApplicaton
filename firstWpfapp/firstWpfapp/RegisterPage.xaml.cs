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
using System.Diagnostics;
using System.ComponentModel;

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
            //creating a user & populating data 
            Users user = new Users();
            populateUserData(user);
            //flag to check if username already exists
            Boolean isRegistered = false;


            //List of existing usernames
            List<String> existingUsernames = new List<String>();
            getExistingUsers(existingUsernames);

            //Iterrating over the existing usernames -- > flag update
            foreach(string existingUsername in existingUsernames)
            {
                if (user.getUsername().Equals(existingUsername))
                    isRegistered = true; 
                else 
                    isRegistered = false;
                
            }

            if (isRegistered.Equals(true)) {
                MessageBox.Show("User with same username found: " + user.getUsername());
            }



            if (txtName.Text.Length <= 2 || String.IsNullOrWhiteSpace(txtName.Text))
            {
                lbl.Content = "Username must contain more than 2 characters!";
                txtName.Focus();
            }
            else if (txtPassword.Password.Length <= 2 || String.IsNullOrWhiteSpace(txtPassword.Password))
            {
                lbl.Content = "Password must be greater than 2 symbols!";
                txtPassword.Focus();
            }
            else if (!txtConfirmPassword.Password.Equals(txtPassword.Password) || String.IsNullOrWhiteSpace(txtConfirmPassword.Password))
            {
                lbl.Content = " Password fields must contain same passwords!";
                txtConfirmPassword.Focus();
            }
            else if (String.IsNullOrEmpty(txtDisplayFirstName.Text) || String.IsNullOrWhiteSpace(txtDisplayFirstName.Text))
            {
                lbl.Content = "First name can't be empty!";
                txtDisplayFirstName.Focus();
            }
            else if (String.IsNullOrEmpty(txtDisplayLastName.Text) || String.IsNullOrWhiteSpace(txtDisplayLastName.Text))
            {
                lbl.Content = "Last name can't be empty!";
                txtDisplayLastName.Focus();
            }


            else
            {
                _cs.regUser(user);
                MessageBox.Show("Successfully registered!");
                this.Close();
            }
        } 

        private List<String> getExistingUsers(List<String> existingUsernames)
        {
            //List of existing usernames --> Connection.GetExistingUsernames()
            existingUsernames = _cs.getExistingUsernames();
            return existingUsernames;
        }

        private Users populateUserData(Users user)
        {
            //Assigning text fields values to string values
            String firstName = txtDisplayFirstName.Text;
            String lastName = txtDisplayLastName.Text;
            String company = txtCompanyName.Text;
            String position = txtPosition.Text;
            String username = txtName.Text;
            String password = txtPassword.Password;
            String confirmPassword = txtConfirmPassword.Password;
            DateTime regDate = DateTime.Now;


            user.setFirstName(firstName);
            user.setLastName(lastName);
            user.setUsername(username);
            user.setPassword(password);
            user.setCompany(company);
            user.setPosition(position);
            user.setRegDate(regDate);

            return user;
        }


     /*   private void values()
        {

            List<String> ErrorMessages = new List<String>(6);
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
            }
            //confirm password
            if (!txtConfirmPassword.Password.Equals(txtPassword.Password))
            {
                txtConfirmPassword.Password = " ";
                txtConfirmPassword.Foreground = Brushes.Red;
            }
        } */

     /*   private void txtFormatting()
        {
            txtDisplayFirstName.Text = "";
            txtDisplayLastName.Text = "";
            txtCompanyName.Text = "";
            txtPosition.Text = "";
            txtName.Text = "";
            txtPassword.Password = "";
            txtConfirmPassword.Password = "";
        } */
    }
}
