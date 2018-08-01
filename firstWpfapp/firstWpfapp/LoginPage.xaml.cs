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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ConnectionString cs = new ConnectionString();
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            lbl.Content = "Connection to the server established!";

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            List<Users> users = cs.getUsers();

            var username = txtName.Text;
            var password = txtPassword.Password;

            foreach(Users user in users)
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
