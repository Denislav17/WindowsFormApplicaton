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
            InitializeComponent();
            cs.getUsers();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            String username;
            String password;

            username = txtName.Text;
            password = txtPassword.Password;
            DateTime regDate = DateTime.Now;
            cs.regUser(username, password, regDate);
            MessageBox.Show("Successfully registered!");
            this.Close();

        }
    }
}
