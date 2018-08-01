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
    /// Interaction logic for AddContact.xaml
    /// </summary>
    public partial class AddContact : Window
    {
        private Users _user;
        private ConnectionString cs = new ConnectionString();
        private List<Users> _listOfUsers = new List<Users>();

        public AddContact(Users user)
        {
            InitializeComponent();
            _user = user;
            this.Title = "Add Contact to: " + user.getFirstName() + " " + user.getLastName() + "'s contact basket";

            _listOfUsers = cs.getExistingUsersData();
            fillListOfUsers();
        }

        private void fillListOfUsers()
        {
            foreach (Users user in _listOfUsers)
            {
                existingUsersList.Items.Add(user.toString());
            }

        }

        private void existingUsersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtFirstName.Text = _listOfUsers[existingUsersList.SelectedIndex].getFirstName();
            txtLastName.Text = _listOfUsers[existingUsersList.SelectedIndex].getLastName();
            txtCompany.Text = _listOfUsers[existingUsersList.SelectedIndex].getCompany();
            txtPosition.Text = _listOfUsers[existingUsersList.SelectedIndex].getPosition();
            txtCardNumber.Text = _listOfUsers[existingUsersList.SelectedIndex].getCardNumber();
        }

        private void btnAddToContactBasket_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cs.addToUserContactBasket(_user, _listOfUsers[existingUsersList.SelectedIndex]);
                MessageBox.Show("User has been successfully added to your contact list.");
            }
            catch (Exception)
            {

               MessageBox.Show("Please ensure that you have selected a user from the dropdown list.");
            }                   
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            ControlPanel cp = new ControlPanel(_user);
            cp.Show();
            this.Close();
        }
    }
}
