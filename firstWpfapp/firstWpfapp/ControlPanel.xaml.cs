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
using System.Windows.Shapes;

namespace firstWpfapp
{
    /// <summary>
    /// Interaction logic for ControlPanel.xaml
    /// </summary>
    public partial class ControlPanel : Window
    {
        private Users _user;
        public ControlPanel(Users user)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.Title = "Control Panel of : " + user.getUsername();
            _user = user;
            
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        private void btnAddContact_Click(object sender, RoutedEventArgs e)
        {
            AddContact ac = new AddContact(_user);
            ac.Show();
            this.Close();
            
        }

        private void btnViewContacts_Click(object sender, RoutedEventArgs e)
        {
            ContactsBasket cb = new ContactsBasket(_user);
        }

        private void btnCalendar_Click(object sender, RoutedEventArgs e)
        {
            //to implement open form window with calendar
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //to implement open form window with calendar
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            ControlPanel cp = new ControlPanel(_user);
            cp.Show();
            this.Close();
        }

    }
}
