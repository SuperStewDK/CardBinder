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
using Domain;

/*
Author: Steffen Rasmussen
Purpose: Looks up the specific user, and provides the information
*/

namespace CardCollectionGUI
{
    
    public partial class LookupWindow : Window
    {
        IController control;
        string name;
        public LookupWindow(String username)
        {
            InitializeComponent();
            CenterWindowOnScreen();
            control = DomainController.getInstance();
            this.Show();
            name = username;
            findUser(username);
        }

        private void findUser(string username)
        {
            User u = control.findUser(username);
            if (u == null)
                displayuserlabel.Content = "No user found";
            else
                displayuserlabel.Content = u.Username;
        }

        // Centers the main window
        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DBconn conn = new DBconn();

            conn.deleteUser(name);

            this.Close();
        }
    }
}
