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
        public ContactsBasket()
        {
            InitializeComponent();
            fillListOfUsers();
        }

        private void fillListOfUsers()
        {
            String fname;
            String lname;
            List<Users> listOfUsers = new List<Users>();
            listOfUsers = cs.getUserData();
            
            foreach (Users user in listOfUsers)
            {
                fname = user.getFirstName();
                lname = user.getLastName();
                usersList.Items.Add(fname + " " + lname);
            }
            
        }
    }
}
