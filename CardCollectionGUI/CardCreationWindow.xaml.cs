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
    }
}
