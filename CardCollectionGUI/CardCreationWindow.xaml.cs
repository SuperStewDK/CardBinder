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
Author: Steffen Rasmussen, Mikkel B. Christensen.
Purpose: Is used to visualize the creation of cards.
*/

namespace CardCollectionGUI
{

    public partial class CardCreationWindow : Window
    {
     
        public CardCreationWindow()
        {
            InitializeComponent();
            CenterWindowOnScreen();
           
            this.Show();
        }

        //opens a new window with the card information
        private void binderbutton_Click(object sender, RoutedEventArgs e)
        {
            string name, imagepath;
            int f, b, h, s;
            name = namebox.Text;
            imagepath = imagepathbox.Text;
            f = Int32.Parse(friendbox.Text);
            b = Int32.Parse(bravebox.Text);
            h = Int32.Parse(humorbox.Text);
            s = Int32.Parse(starbox.Text);

            DBconn conn = new DBconn();

            conn.createCard(name, imagepath, f, b, h, s);
        }

        // Centers the window
        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }


        //Focus Event to remove text currently in the window.
        private void gotFocus_Event(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= gotFocus_Event;
        }

    }
}
