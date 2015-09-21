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

namespace CardCollectionGUI
{

    public partial class CardCreationWindow : Window
    {
        private static CardCreationWindow instance;

        // A singleton that ensures only one window of this instance is open
        public static CardCreationWindow getInstance()
        {
            if (instance == null)
            {
                instance = new CardCreationWindow();
            }
            return instance;
        }

        public CardCreationWindow()
        {
            InitializeComponent();
            CenterWindowOnScreen();
        }

        //opens a new window with the card information
        private void binderbutton_Click(object sender, RoutedEventArgs e)
        {
            
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

        private void namebox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Removes text from the text box when clicked
        private void namebox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= namebox_GotFocus;   
        }

        private void imagepathbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Removes text from the text box when clicked
        private void imagebox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= imagebox_GotFocus;
        }

        private void friendbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Removes text from the text box when clicked
        private void friendbox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= friendbox_GotFocus;
        }

        private void bravebox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Removes text from the text box when clicked
        private void bravebox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= bravebox_GotFocus;
        }

        private void humorbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Removes text from the text box when clicked
        private void humorbox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= humorbox_GotFocus;
        }

        private void starbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Removes text from the text box when clicked
        private void starbox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= starbox_GotFocus;
        }
    }
}
