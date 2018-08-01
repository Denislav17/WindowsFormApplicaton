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
    /// Interaction logic for ContactsBasket.xaml
    /// </summary>
    public partial class ContactsBasket : Window
    {

        private ConnectionString cs = new ConnectionString();
        private List<Users> _listOfUsers = new List<Users>();
        private Users _user;
        public ContactsBasket(Users user)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.Title = "Contact Basket of : " + user.getUsername();
            _user = user;

            _listOfUsers = cs.getAddedContactsData(user);
            fillListOfUsers();
            
        }

        private void fillListOfUsers()
        {
            foreach (Users user in _listOfUsers)
            {
               usersList.Items.Add(user.toString());
            }
            
        }

        private void usersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtFirstName.Text = _listOfUsers[usersList.SelectedIndex].getFirstName();
            txtLastName.Text = _listOfUsers[usersList.SelectedIndex].getLastName();
            txtCompany.Text = _listOfUsers[usersList.SelectedIndex].getCompany();
            txtPosition.Text = _listOfUsers[usersList.SelectedIndex].getPosition();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            ControlPanel cp = new ControlPanel(_user);
            cp.Show();
            this.Close();
        }
    }
}
