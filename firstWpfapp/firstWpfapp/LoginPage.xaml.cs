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
using System.Threading;

namespace firstWpfapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginPage : Window 
    {
        private ConnectionString _cs = new ConnectionString();
        private List<Users> _users = new List<Users>();

        public LoginPage()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            lbl.Content = "Connection to the server established!";

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            _cs.getUsers(_users);

            var username = txtName.Text;
            var password = txtPassword.Password;

            foreach(Users user in _users)
            {
                if (username.Equals(user.getUsername()) && password.Equals(user.getPassword()) )
                {
                    ControlPanel cp = new ControlPanel(user);
                    this.Close();
                    cp.Show();
                } 
                else
                {
                    lbl.Content = " Credentials incorrect! Please verify.";
                }
            }
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            RegisterPage rp = new RegisterPage();
            rp.Show();         
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            lbl.Content = "Connection to server terminated!";
            this.Close();
        }
    }
}
