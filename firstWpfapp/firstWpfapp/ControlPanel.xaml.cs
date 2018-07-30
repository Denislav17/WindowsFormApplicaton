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
        public ControlPanel()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddContact_Click(object sender, RoutedEventArgs e)
        {
            //to implement open form to add contact
        }

        private void btnViewContacts_Click(object sender, RoutedEventArgs e)
        {
            ContactsBasket cb = new ContactsBasket();
        }

        private void btnCalendar_Click(object sender, RoutedEventArgs e)
        {
            //to implement open form window with calendar
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //to implement open form window with calendar
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //to implement open form window with calendar
        }

    }
}
